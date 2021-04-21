using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmartWatch.Data;
using SmartWatch.DTOs.DetailWatch;
using SmartWatch.Models;

namespace SmartWatch.Services.DetailWatch
{
    public class DetailWatchService : ServiceBase, IDetailWatchService
    {
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger _log;
        private readonly IHttpContextAccessor _httpContext;
        public DetailWatchService(IHttpContextAccessor httpContext
            , AppDBContext dbContext
            , IMapper mapper
            , ILogger<DetailWatchService> log) : base(dbContext, mapper, httpContext)
            {
                _dbContext = dbContext;
                _mapper = mapper;
                _log = log;
                    _httpContext = httpContext;
                }
                //DetailWatch

                public async Task<ServiceResponse<List<Models.DetailWatch>>> GetDetailWatch()
                {
                    var detailWatch = await (_dbContext.DetailWatchs.Include(x => x.ColorWatch).ToListAsync());
                    return ResponseResult.Success(detailWatch);
                }

                public async Task<ServiceResponse<Models.DetailWatch>> SearchDetailWatch(int id)
                {
                    var searchDetailWatch = await (_dbContext.DetailWatchs.Where(x => x.Id == id).Include(x => x.ColorWatch).SingleOrDefaultAsync());
                    return ResponseResult.Success(searchDetailWatch);
                }

                public async Task<ServiceResponse<DetailWatchDTO_ToReturn>> CreateDetailWatch(DetailWatchDTO_ToCreate create)
                {
                    var checkDetailWatch = await (_dbContext.DetailWatchs.Where(x => x.ColorId == create.ColorId).FirstOrDefaultAsync());
                    if(checkDetailWatch != null){
                        return ResponseResult.Failure<DetailWatchDTO_ToReturn>("Can't CrateDetailWatch");
                    }

                    var createDetailWatch = new Models.DetailWatch();
                    createDetailWatch.ColorId = create.ColorId;
                    createDetailWatch.CreateDate = DateTime.Now;

                    await _dbContext.DetailWatchs.AddAsync(createDetailWatch);
                    await _dbContext.SaveChangesAsync();

                    var resultToReturn = _mapper.Map<DetailWatchDTO_ToReturn>(createDetailWatch);
                    return ResponseResult.Success(resultToReturn);
                }

    }
}