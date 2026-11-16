using CinemaAutomation.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaAutomation.DataAccess.Mappings
{
    public class MovieMap : EntityTypeConfiguration<Movie>
    {
        public MovieMap()
        {
            ToTable("Movies");
            HasKey(m => m.Id);
            Property(m => m.Title).IsRequired().HasMaxLength(100);
            Property(m => m.Genre).IsRequired().HasMaxLength(50);
            Property(m => m.Director).IsRequired().HasMaxLength(50);
            Property(m => m.Duration).IsRequired();
            Property(m => m.ReleaseDate).HasColumnType("datetime");

            
        }
    }
}
