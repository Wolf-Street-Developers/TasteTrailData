using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasteTrailData.Core.VenuePhotos.Models;

namespace TasteTrailData.Core.VenuePhotos.Configurations;

public class VenuePhotoConfiguration : IEntityTypeConfiguration<VenuePhoto>
{
    public void Configure(EntityTypeBuilder<VenuePhoto> builder)
    {
        builder.HasKey(vp => vp.Id);

        builder.Property(vp => vp.PhotoUrlPath)
            .IsRequired()
            .HasMaxLength(500);
    }
}