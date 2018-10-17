﻿using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Globalization
{
    public class LocalizedAccommodation : Localized
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string CheckInTime { get; set; }

        public string CheckOutTime { get; set; }

        public virtual Accommodation Accommodation { get; set; }
    }
}