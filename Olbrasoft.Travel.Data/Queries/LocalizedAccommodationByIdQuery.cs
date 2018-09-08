﻿using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Queries
{
    public class LocalizedAccommodationByIdQuery : BaseQuery<LocalizedAccommodation, LocalizedAccommodation>
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }

    }
}