using System.Collections.Generic;
using System.Threading.Tasks;
using SmartWatch.DTOs;
using SmartWatch.DTOs.ColorWatch;
using SmartWatch.DTOs.DetailWatch;
using SmartWatch.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SmartWatch.Services.BrandWatch
{
    public interface IBrandWatchService
    {

        //BrandWatch
         Task<ServiceResponse<List<Models.BrandWatch>>> GetBrandWatch();
         Task<ServiceResponse<Models.BrandWatch>> SeartBrandWatch(int id);
         Task<ServiceResponse<BrandWatchDTO_ToReturn>> CreateBrandWatch(BrandWatchDTO_ToCreate create);
         Task<ServiceResponse<BrandWatchDTO_ToReturn>> UpdateBrandWatch(int id,BrandWatchDTO_ToUpdate update);

         
    }
}