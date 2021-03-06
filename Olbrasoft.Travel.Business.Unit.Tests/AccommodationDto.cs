﻿using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Business.Unit.Tests
{
    public class AccommodationDto
    {
        public int Id { get; set; }

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