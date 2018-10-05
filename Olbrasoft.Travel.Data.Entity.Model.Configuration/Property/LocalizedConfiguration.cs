namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public abstract class LocalizedConfiguration<TEntity> : PropertyConfiguration<TEntity>
        where TEntity : Localized
    {
        protected LocalizedConfiguration()
        {
            HasKey(p => new { p.Id, p.LanguageId });
        }
    }
}