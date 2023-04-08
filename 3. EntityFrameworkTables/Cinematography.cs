namespace EntityFrameworkTables
{
    using System;
    using System.Data.Entity;
    using System.Collections.Generic;

    public partial class Cinematography : DbContext
    {
        public Cinematography()
            : base("name=EntityFrameworkTables.Properties.Settings.CinematographyConnectionString")
        {
        }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
    }

    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public string Director { get; set; }
        public List<Genre> Genres { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; }
    }
}
