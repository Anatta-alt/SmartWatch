using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartWatch.Models
{
    public class BrandWatch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string WatchName { get; set; }

        public List<DetailWatch> DetailWatch { get; set; }


        [Required]
        public int Price { get; set; }
        
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}