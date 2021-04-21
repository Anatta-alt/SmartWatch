using System;
using System.ComponentModel.DataAnnotations;

namespace SmartWatch.Models
{
    public class DetailWatch
    {
        [Key]
        public int Id { get; set; }

        public int? BrandWatchId { get; set; }

        public BrandWatch BrandWatch { get; set; }

        [Required]
        public int? ColorId { get; set; }

        public ColorWatch ColorWatch { get; set; }


        public DateTime CreateDate { get; set; }
    }
}