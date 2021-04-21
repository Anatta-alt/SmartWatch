using System.ComponentModel.DataAnnotations;

namespace SmartWatch.DTOs.DetailWatch
{
    public class DetailWatchDTO_ToCreate
    {
        [Required]
        public int ColorId { get; set; }


    }
}