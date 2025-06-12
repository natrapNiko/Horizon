
namespace Horizons.Data.Configurations
{
    using Horizons.Data.Models;
    using static GCommon.ValidationConstants.Terrain;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;


    public class TerrainConfiguration : IEntityTypeConfiguration<Terrain>
    {
        public void Configure(EntityTypeBuilder<Terrain> entity)
        {
            entity
                .HasKey(t => t.Id);

            entity
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(TerrainMaxLength);
        }
    }
}
