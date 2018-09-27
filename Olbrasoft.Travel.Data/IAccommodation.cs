﻿namespace Olbrasoft.Travel.Data
{
    public interface IAccommodation
    {
        int Id { get; set; }
        decimal StarRating { get; set; }
        string Name { get; set; }
        string Location { get; set; }
        string Address { get; set; }
    }
}