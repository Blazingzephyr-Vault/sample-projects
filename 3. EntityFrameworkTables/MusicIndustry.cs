namespace EntityFrameworkTables
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;

    public partial class MusicIndustry : DbContext
    {
        public MusicIndustry()
            : base("name=EntityFrameworkTables.Properties.Settings.MusicIndustryConnectionString")
        {
        }

        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Singer> Singer { get; set; }
    }

    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Singer> Singers { get; set; }
    }

    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
    }
}
