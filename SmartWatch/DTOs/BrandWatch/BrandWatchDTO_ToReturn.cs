using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmartWatch.DTOs
{
    public class BrandWatchDTO_ToReturn
    {
        public string WatchName { get; set; }


        public int Price { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}