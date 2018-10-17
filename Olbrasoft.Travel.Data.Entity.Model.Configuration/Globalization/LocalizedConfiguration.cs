namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public abstract class LocalizedConfiguration<TEntity> : GlobalizationConfiguration<TEntity> where TEntity : Localized
    {
        protected LocalizedConfiguration()
        {
            HasKey(p => new { p.Id, p.LanguageId });
        }
    }
}