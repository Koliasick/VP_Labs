using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_7
{
    public class VideoStoreContext : DbContext
    {
        public DbSet<VideoTape> Tapes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Agency> Agencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-EIJVPSS;Initial Catalog=VP_7;Integrated Security=True");
            }
        }
    }

    public class VideoTape 
    {
        public int Id { get; set; }
        public string? RecordType { get; set; }
        public string? Name { get; set; }
        public string? RTFText { get; set; }
        public DateTime? RecievementDate { get; set; }
        public DateTime? RecordDate { get; set; }
        public TimeSpan? RecordLength { get; set; }
        public List<Author> Authors { get; set; }
    }

    public class Author 
    {
        public int Id { get; set; }
        public List<VideoTape> Tapes { get; set; }
        public Photo? Photo { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public Agency? Agency { get; set; }
    }

    public class Photo
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte[]? Data { get; set; }
    }

    public class Agency 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Author> Authors { get; set; }
        public string? Address { get; set; }
        public string? DirectorName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
