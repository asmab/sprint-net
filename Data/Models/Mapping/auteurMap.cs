using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Models.Mapping
{
    public class auteurMap : EntityTypeConfiguration<auteur>
    {
        public auteurMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Nom)
                .IsRequired()
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("auteur", "media");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Nom).HasColumnName("Nom");
        }
    }
}
