using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineLearningPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningPlatform.Configurations
{
    public class CoursesConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Price).HasPrecision(10, 2).IsRequired();
            builder.Property(x => x.PublishDate).HasDefaultValueSql("GetDate()");

            builder.HasOne(x => x.Instructor)
                   .WithMany(x => x.courses)
                   .HasForeignKey(x => x.InstructorId);
        }
    }
}
