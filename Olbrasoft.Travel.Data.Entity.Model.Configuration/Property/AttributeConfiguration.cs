namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class AttributeConfiguration : Configuration.Property.CreatorConfiguration<Model.Property.Attribute>
    {
        public AttributeConfiguration()
        {
            ToTable("Attributes");

            HasRequired(a => a.TypeOfAttribute).WithMany(toa => toa.Attributes).WillCascadeOnDelete(false);

            HasRequired(a => a.SubTypeOfAttribute).WithMany(toa => toa.Attributes).WillCascadeOnDelete(false);
        }
    }
}