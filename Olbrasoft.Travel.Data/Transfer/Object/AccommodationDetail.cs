﻿using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Transfer.Object
{
    public class AccommodationDetail : Accommodation
    {
        public string Description { get; set; }

        public string[] Photos { get; set; }

        [Range(typeof(double), "-90", "90")]
        public double Latitude { get; set; }

        [Range(typeof(double), "-180", "180")]
        public double Longitude { get; set; }

    }
}