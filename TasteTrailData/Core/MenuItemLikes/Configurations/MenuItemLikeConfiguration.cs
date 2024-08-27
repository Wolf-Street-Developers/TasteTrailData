using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasteTrailData.Core.MenuItemLikes.Models;

namespace TasteTrailData.Core.MenuItemLikes.Configurations;

public class MenuItemLikeConfiguration : IEntityTypeConfiguration<MenuItemLike>
{
    public void Configure(EntityTypeBuilder<MenuItemLike> builder)
    {
        builder.HasKey(mi => mi.Id);

        builder.Property(u => u.MenuItemId)
            .IsRequired();

        builder.Property(u => u.UserId)
            .IsRequired();

        builder
            .HasIndex(mi => new {mi.MenuItemId , mi.UserId})
            .IsUnique();
    }
}
