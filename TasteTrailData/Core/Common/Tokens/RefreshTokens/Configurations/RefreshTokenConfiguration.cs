using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasteTrailData.Core.Common.Tokens.RefreshTokens.Entities;

namespace TasteTrailData.Core.Common.Tokens.RefreshTokens.Configurations;

public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder
            .HasKey(rt => rt.Token);

        builder
            .HasOne(rt => rt.User)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired();
    }
}