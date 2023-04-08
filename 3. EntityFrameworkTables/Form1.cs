
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EntityFrameworkTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmsTableAdapter.Fill(cinematographyDataSet.Films);
            genresTableAdapter.Fill(cinematographyDataSet1.Genres);
            genreFilmsTableAdapter.Fill(cinematographyDataSet2.GenreFilms);

            singersTableAdapter.Fill(musicIndustryDataSet.Singers);
            songsTableAdapter.Fill(musicIndustryDataSet1.Songs);
            songSingersTableAdapter.Fill(musicIndustryDataSet2.SongSingers);
        }

        private void Create(object sender, EventArgs e)
        {
            Cinematography cinematography = new Cinematography();
            Film film = new Film { Name = "Titanic", Duration = TimeSpan.FromMinutes(220), Director = "James Cameron" };
            Genre romance = new Genre { Name = "Romance", Films = new List<Film>() { film } };
            Genre drama = new Genre { Name = "Drama", Films = new List<Film>() { film } };
            film.Genres = new List<Genre>() { romance, drama };

            cinematography.Films.Add(film);
            cinematography.Genres.AddRange(new[] { romance, drama });
            cinematography.SaveChanges();

            MusicIndustry musicIndustry = new MusicIndustry();
            Singer singer = new Singer { Name = "CoolSinger" };
            Song song1 = new Song { Name = "IdkCool", Duration = TimeSpan.FromMinutes(1.5d), Singers = new List<Singer>() { singer } };
            Song song2 = new Song { Name = "IdkCool", Duration = TimeSpan.FromMinutes(1.5d), Singers = new List<Singer>() { singer } };

            musicIndustry.Singer.Add(singer);
            musicIndustry.Songs.AddRange(new[] { song1, song2 });
            musicIndustry.SaveChanges();
        }
    }
}