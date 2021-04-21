using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmartWatch.Data;
using SmartWatch.DTOs;
using SmartWatch.DTOs.DetailWatch;
using SmartWatch.Models;

namespace SmartWatch.Services.BrandWatch
{
    public class BrandWatchService : ServiceBase, IBrandWatchService
    {
          
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger _log;
        private readonly IHttpContextAccessor _httpContext;
        public BrandWatchService(IHttpContextAccessor httpContext
            , AppDBContext dbContext
            , IMapper mapper
            , ILogger<BrandWatchService> log) : base(dbContext, mapper, httpContext)
            {
                _dbContext = dbContext;
                _mapper = mapper;
                _log = log;
                    _httpContext = httpContext;
                }


                //BrandWatch
                
                public async Task<ServiceResponse<List<Models.BrandWatch>>> GetBrandWatch()
                {
                    var brandWatch = await (_dbContext.BrandWatchs.Include(x => x.DetailWatch).ThenInclude(x => x.ColorWatch).ToListAsync());
                    return ResponseResult.Success(brandWatch);
                }

                public async Task<ServiceResponse<Models.BrandWatch>> SeartBrandWatch(int id)
                {
                    var searchBrandWatch = await (_dbContext.BrandWatchs.Where(x => x.Id == id).Include(x => x.DetailWatch).ThenInclude(x => x.ColorWatch).SingleOrDefaultAsync());
                    return ResponseResult.Success(searchBrandWatch);
                }

                public async Task<ServiceResponse<BrandWatchDTO_ToReturn>> CreateBrandWatch(BrandWatchDTO_ToCreate create)
                {
                    var checkBrandWatch = await (_dbContext.BrandWatchs.Where(x => x.WatchName == create.WatchName).FirstOrDefaultAsync());
                    if(checkBrandWatch != null){
                        return ResponseResult.Failure<BrandWatchDTO_ToReturn>("Can't CrateBandWatch");
                    }

                    var createBrandWatch = new Models.BrandWatch();
                    createBrandWatch.WatchName = create.WatchName;
                    createBrandWatch.Price = create.Price;
                    createBrandWatch.CreateDate = DateTime.Now;

                    await _dbContext.BrandWatchs.AddAsync(createBrandWatch);
                    await _dbContext.SaveChangesAsync();

                    var resultToReturn = _mapper.Map<BrandWatchDTO_ToReturn>(createBrandWatch);
                    return ResponseResult.Success(resultToReturn);
                }

                 public async Task<ServiceResponse<BrandWatchDTO_ToReturn>> UpdateBrandWatch(int id ,BrandWatchDTO_ToUpdate update)
                {
                    var updateBrandWatch = await (_dbContext.BrandWatchs.Where(x => x.Id == id).FirstOrDefaultAsync());
                    if(updateBrandWatch == null){
                        return ResponseResult.Failure<BrandWatchDTO_ToReturn>("Can't UpdateBandWatch");
                    }

                    updateBrandWatch.WatchName = update.WatchName;
                    updateBrandWatch.Price = update.Price;
                    updateBrandWatch.CreateDate = DateTime.Now;

                    await _dbContext.BrandWatchs.AddAsync(updateBrandWatch);
                    await _dbContext.SaveChangesAsync();

                    var resultToReturn = _mapper.Map<BrandWatchDTO_ToReturn>(updateBrandWatch);
                    return ResponseResult.Success(resultToReturn);
                }

                


        
    }
}