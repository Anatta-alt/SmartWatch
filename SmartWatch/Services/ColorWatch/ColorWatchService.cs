using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SmartWatch.Data;
using SmartWatch.DTOs.ColorWatch;
using SmartWatch.Models;

namespace SmartWatch.Services .ColorWatch
{
    public class ColorWatchService : ServiceBase, IColorWatchService
    {
        private readonly AppDBContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger _log;
        private readonly IHttpContextAccessor _httpContext;
        public ColorWatchService(IHttpContextAccessor httpContext
            , AppDBContext dbContext
            , IMapper mapper
            , ILogger<ColorWatchService> log) : base(dbContext, mapper, httpContext)
            {
                _dbContext = dbContext;
                _mapper = mapper;
                _log = log;
                    _httpContext = httpContext;
                    
                }


        public async Task<ServiceResponse<List<Models.ColorWatch>>> GetColorWatch()
        {
            var colorlWatch = await (_dbContext.ColorWatchs.ToListAsync());
            return ResponseResult.Success(colorlWatch);
        }

        public async Task<ServiceResponse<Models.ColorWatch>> SearchColorWatch(int id)
        {
            var searchColorlWatch = await (_dbContext.ColorWatchs.Where(x => x.Id == id).SingleOrDefaultAsync());
            return ResponseResult.Success( searchColorlWatch);
        }

        public async Task<ServiceResponse<ColorWatchDTO_ToReturn>> CreateColorWatch(ColorWatchDTO_ToCreate create)
        {
            var checkColorWatch = await (_dbContext.ColorWatchs.Where(x => x.Color == create.Color).FirstOrDefaultAsync());
            if(checkColorWatch != null){
                return ResponseResult.Failure<ColorWatchDTO_ToReturn>("Can't CrateDetailWatch");
            }

            var createColorWatch = new Models.ColorWatch();
            createColorWatch.Color = create.Color;
            createColorWatch.CreateDate = DateTime.Now;

            await _dbContext.ColorWatchs.AddAsync(createColorWatch);
            await _dbContext.SaveChangesAsync();

            var resultToReturn = _mapper.Map<ColorWatchDTO_ToReturn>(createColorWatch);
            return ResponseResult.Success(resultToReturn);
        }

    }
}