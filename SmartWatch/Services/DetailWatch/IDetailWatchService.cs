using System.Collections.Generic;
using System.Threading.Tasks;
using SmartWatch.DTOs.DetailWatch;
using SmartWatch.Models;

namespace SmartWatch.Services.DetailWatch
{
    public interface IDetailWatchService
    {
         //DetailWatch
         Task<ServiceResponse<List<Models.DetailWatch>>> GetDetailWatch();
         Task<ServiceResponse<Models.DetailWatch>> SearchDetailWatch(int id);
         Task<ServiceResponse<DetailWatchDTO_ToReturn>> CreateDetailWatch(DetailWatchDTO_ToCreate create);
    }
}