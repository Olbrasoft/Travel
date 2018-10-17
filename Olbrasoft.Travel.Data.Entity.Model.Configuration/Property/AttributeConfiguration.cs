namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class AttributeConfiguration : CreatorConfiguration<Model.Property.Attribute>
    {
        public AttributeConfiguration()
        {
            ToTable("Attributes");

            HasRequired(attribute => attribute.TypeOfAttribute).WithMany(toa => toa.Attributes).WillCascadeOnDelete(false);

            HasRequired(attribute => attribute.SubTypeOfAttribute).WithMany(toa => toa.Attributes).WillCascadeOnDelete(false);
        }
    }
}