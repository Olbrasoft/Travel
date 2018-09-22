namespace Olbrasoft.Travel.Data.Entities
{
    public class RegionToRegion : ManyToMany
    {
        public virtual Region Region { get; set; }

        public virtual Region ParentRegion { get; set; }
    }
}