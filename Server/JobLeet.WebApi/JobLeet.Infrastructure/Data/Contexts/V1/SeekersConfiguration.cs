using System.Text.Json;
using JobLeet.WebApi.JobLeet.Core.Entities.Seekers.V1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobLeet.WebApi.JobLeet.Infrastructure.Repositories.Seekers.V1
{
    public class SeekersConfiguration : IEntityTypeConfiguration<Seeker>
    {
        public void Configure(EntityTypeBuilder<Seeker> builder)
        {
            builder.ToTable("jblt_seeker");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("seeker_id");
            builder.Property(e => e.DateOfBirth).HasColumnName("seeker_dob");
            builder.Property(e => e.ProfileSummary).HasColumnName("seeker_profilesummary");
            builder.Property(e => e.LinkedInProfile).HasColumnName("seeker_linkedin");

            var valueComparer = new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()
            );

            builder
                .Property(e => e.Interests)
                .HasColumnName("job_interests")
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null)
                )
                .Metadata.SetValueComparer(valueComparer);

            builder
                .Property(e => e.Achievements)
                .HasColumnName("job_achievements")
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<List<string>>(v, (JsonSerializerOptions)null)
                )
                .Metadata.SetValueComparer(valueComparer);
        }
    }
}
