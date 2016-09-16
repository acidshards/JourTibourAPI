using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JourTibourApi.Models
{
    public class JourTibourContext : DbContext
    {
        public JourTibourContext(DbContextOptions<JourTibourContext> options)
            : base(options)
        { }

        public DbSet<Edition> Editions { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Stage> Stages { get; set; }
        public DbSet<Artist> Artists { get; set; }
        
    }

    public class Edition
    {
        public int EditionId { get; set; }
        public DateTime FestivalDate { get; set; }

        public List<Performance> Performances { get; set; }
    }

    public class Performance
    {
        public int PerformanceId { get; set; }
        public Artist Artist { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Stage { get; set; }

    }

    public class Stage
    {
        public int StageId { get; set; }
        public string StageName { get; set; }
    }

    public class Artist
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
