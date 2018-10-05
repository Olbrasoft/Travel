namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public abstract class NameConfiguration<TEntity> : CreatorConfiguration<TEntity> where TEntity : BaseName
    {
        protected NameConfiguration()
        {
            Property(p => p.Name).HasMaxLength(50).IsRequired();
        }
    }
}