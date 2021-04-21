using System.ComponentModel.DataAnnotations;

namespace SmartWatch.DTOs
{
    public class BrandWatchDTO_ToUpdate
    {
        [Required]
        [StringLength(50)]
        public string WatchName { get; set; }


        [Required]
        public int Price { get; set; }

        public int MyProperty { get; set; }
    }
}