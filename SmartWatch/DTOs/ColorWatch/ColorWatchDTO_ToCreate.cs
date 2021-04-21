using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWatch.DTOs.ColorWatch
{
    public class ColorWatchDTO_ToCreate
    {

        [Required]
        [StringLength(50)]
        public string Color { get; set; }
        
    }
}