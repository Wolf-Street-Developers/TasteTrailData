using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TasteTrailData.Core.Feedbacks.Models;

namespace TasteTrailData.Core.Feedbacks.Configurations;


public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> builder)
    {
        builder.HasKey(f => f.Id); 

        builder.Property(f => f.Text)
            .IsRequired();

        builder.Property(f => f.Rating)
            .IsRequired()
            .HasPrecision(7, 2);

        builder.Property(f => f.Likes)
            .IsRequired();

        builder.Property(f => f.CreationDate)
            .IsRequired();
    }
}