using System.Collections.Generic;
using System.Threading.Tasks;
using SmartWatch.DTOs.ColorWatch;
using SmartWatch.Models;

namespace SmartWatch.Services
{
    public interface IColorWatchService
    {
         //ColorWatch
         Task<ServiceResponse<List<Models.ColorWatch>>> GetColorWatch();
         Task<ServiceResponse<Models.ColorWatch>> SearchColorWatch(int id);
         Task<ServiceResponse<ColorWatchDTO_ToReturn>> CreateColorWatch(ColorWatchDTO_ToCreate create);
    }
}