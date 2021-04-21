using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWatch.Models
{
    public class ColorWatch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Color { get; set; }
        public DateTime CreateDate { get; set; }
    }
}