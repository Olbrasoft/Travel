﻿namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class RegionToType : ManyToMany
    {
        public int? SubClassId { get; set; }

        public Region Region { get; set; }

        public TypeOfRegion TypeOfRegion { get; set; }

        public SubClass SubClass { get; set; }
    }
}