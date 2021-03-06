﻿using System.ComponentModel.DataAnnotations;
using Olbrasoft.Travel.Expedia.Affiliate.Network.Data.Transfer.Object.Property;

namespace Olbrasoft.Travel.Expedia.Affiliate.Network
{
    public class PathsHotelsImages : BaseParser<PathToHotelImage>, IPathsHotelsImagesParser
    {
        public override PathToHotelImage Parse(string[] items)
        {
            throw new System.NotImplementedException();
        }

        public override bool TryParse(string line, out PathToHotelImage entita)
        {
            var properties= line.Split('|');

            if (!int.TryParse(properties[0], out var eanHotelId))
            {
                entita = null;
                return false;
            }

            entita= new PathToHotelImage
            {
                EANHotelID =eanHotelId,
                URL = properties[2]
            };
            return Validator.TryValidateObject(entita, new ValidationContext(entita), null, true);
        }
        
    }
}