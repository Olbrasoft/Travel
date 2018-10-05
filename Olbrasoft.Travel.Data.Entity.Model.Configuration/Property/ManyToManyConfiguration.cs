namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public abstract class ManyToManyConfiguration<TEntity> : CreatorConfiguration<TEntity>
        where TEntity : ManyToMany
    {
        protected ManyToManyConfiguration()
        {
            HasKey(p => new { p.Id, p.ToId });
        }
    }
}