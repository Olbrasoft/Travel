namespace Olbrasoft.Travel.Data.Entity.Model.Geography
{
    public class RegionToRegion : ManyToMany
    {
        public virtual Region Region { get; set; }

        public virtual Region ParentRegion { get; set; }
    }
}