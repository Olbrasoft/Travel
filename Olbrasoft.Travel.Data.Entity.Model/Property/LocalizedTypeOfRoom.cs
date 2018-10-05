namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class LocalizedTypeOfRoom : Localized
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual TypeOfRoom TypeOfRoom { get; set; }
    }
}