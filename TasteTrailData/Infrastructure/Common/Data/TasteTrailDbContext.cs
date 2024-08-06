using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Configurations;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;
using TasteTrailData.Core.Feedbacks.Configurations;
using TasteTrailData.Core.Feedbacks.Models;
using TasteTrailData.Core.MenuItems.Configurations;
using TasteTrailData.Core.MenuItems.Models;
using TasteTrailData.Core.Menus.Configurations;
using TasteTrailData.Core.Menus.Models;
using TasteTrailData.Core.Roles.Models;
using TasteTrailData.Core.Users.Models;
using TasteTrailData.Core.VenuePhotos.Configurations;
using TasteTrailData.Core.VenuePhotos.Models;
using TasteTrailData.Core.Venues.Configurations;
using TasteTrailData.Core.Venues.Models;

namespace TasteTrailData.Infrastructure.Common.Data;

public class TasteTrailDbContext : IdentityDbContext<User, Role, string>
{
    public DbSet<Menu> Menus { get; set; }

    public DbSet<Venue> Venues { get; set; }

    public DbSet<MenuItem> MenuItems { get; set; }

    public DbSet<RefreshToken> RefreshTokens { get; set; }

    public DbSet<VenuePhoto> VenuePhotos { get; set; }

    public DbSet<Feedback> Feedbacks { get; set; }

    public TasteTrailDbContext(DbContextOptions options) : base(options)
    {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new FeedbackConfiguration());
        modelBuilder.ApplyConfiguration(new MenuConfiguration());
        modelBuilder.ApplyConfiguration(new MenuItemConfiguration());
        modelBuilder.ApplyConfiguration(new VenueConfiguration());
        modelBuilder.ApplyConfiguration(new VenuePhotoConfiguration());
        modelBuilder.ApplyConfiguration(new RefreshTokenConfiguration());
    }

}

