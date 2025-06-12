
namespace Horizons.Data.Configurations
{
    using Horizons.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using static GCommon.ValidationConstants.Destination;

    public class DestinationConfiguration : IEntityTypeConfiguration<Destination>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Destination> entity)
        {
            entity
                .HasKey(d => d.Id);

            entity
                .Property(d => d.Name)
                .IsRequired()
                .HasMaxLength(NameMaxLength);

            entity
                .Property(d => d.Description)
                .IsRequired()
                .HasMaxLength(DescriptionMaxLength);

            entity
                .Property(d => d.ImageUrl)
                .IsRequired(false);

            entity
                .Property(d => d.PublisherId)
                .IsRequired();

            entity
                .Property(d=> d.IsDeleted)
                .HasDefaultValue(false);

            //Take only these destinations that are not deleted (non-deleted)
            entity
                .HasQueryFilter(d=> d.IsDeleted == false);

            entity
                .HasOne(d => d.Publisher)
                .WithMany()
                .HasForeignKey(d => d.PublisherId);

            entity
                .HasOne(d => d.Terrain)
                .WithMany()
                .HasForeignKey(d => d.TerrainId);
        }
    }
}
