﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entities
{
    public class Airport : CreatorInfo, IAdditionalRegionInfo
    {
       
        public string Code { get; set; }

        public Region Region { get; set; }

        public ICollection<Accommodation> Accommodations { get; set; }
    }
}