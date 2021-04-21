using System.ComponentModel.DataAnnotations;

namespace SmartWatch.DTOs
{
    public class BrandWatchDTO_ToCreate
    {
        [Required]
        [StringLength(50)]
        public string WatchName { get; set; }


        [Required]
        public int Price { get; set; }

        [Required]

        public int DetailWatchId { get; set; }
    }
}