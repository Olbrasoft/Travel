﻿using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data
{
    public class Accommodation : IAccommodation
    {
        public int Id { get; set; }

        public decimal StarRating { get; set; }

        [Required]
        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

    }
}