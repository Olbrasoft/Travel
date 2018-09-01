namespace Olbrasoft.Travel.Data.Entities
{
    public class PhotoOfAccommodationToTypeOfRoom : ManyToMany
    {
        public PhotoOfAccommodation PhotoOfAccommodation { get; set; }
        public TypeOfRoom TypeOfRoom { get; set; }

    }
}