namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public abstract class NameConfiguration<TEntity> : CreatorConfiguration<TEntity> where TEntity : BaseName
    {
        protected NameConfiguration()
        {
            Property(p => p.Name).HasMaxLength(50).IsRequired();
        }
    }
}