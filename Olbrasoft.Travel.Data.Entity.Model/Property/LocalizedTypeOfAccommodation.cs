namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class LocalizedTypeOfAccommodation : Localized
    {
        public virtual string Name { get; set; }

        public virtual TypeOfAccommodation TypeOfAccommodation { get; set; }
    }
}