using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasteTrailData.Core.MenuItems.Models;

namespace TasteTrailData.Core.MenuItems.Configurations;

public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
{
    public void Configure(EntityTypeBuilder<MenuItem> builder)
    {
         builder.HasKey(mi => mi.Id);

            builder.Property(mi => mi.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(mi => mi.Description)
                .HasMaxLength(500);

            builder.Property(mi => mi.Price)
                .IsRequired();

            builder.Property(mi => mi.PopularityRate)
                .IsRequired();
    }
}