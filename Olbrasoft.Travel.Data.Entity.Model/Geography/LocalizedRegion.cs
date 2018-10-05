namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class LocalizedRegion : Localized
    {
        public virtual string Name { get; set; }

        public string LongName { get; set; }

        public virtual Region Region { get; set; }
    }
}