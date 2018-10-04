namespace Olbrasoft.Travel.Data.Entities
{
    public class LocalizedRegion : Localized
    {
        public virtual string Name { get; set; }

        public string LongName { get; set; }

        public virtual Region Region { get; set; }
    }
}