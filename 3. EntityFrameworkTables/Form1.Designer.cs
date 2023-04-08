using System;

namespace EntityFrameworkTables
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinematographyDataSet = new EntityFrameworkTables.CinematographyDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinematographyDataSet1 = new EntityFrameworkTables.CinematographyDataSet1();
            this.filmsTableAdapter = new EntityFrameworkTables.CinematographyDataSetTableAdapters.FilmsTableAdapter();
            this.genresTableAdapter = new EntityFrameworkTables.CinematographyDataSet1TableAdapters.GenresTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreFilmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinematographyDataSet2 = new EntityFrameworkTables.CinematographyDataSet2();
            this.genreFilmsTableAdapter = new EntityFrameworkTables.CinematographyDataSet2TableAdapters.GenreFilmsTableAdapter();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.songIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songSingersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicIndustryDataSet2 = new EntityFrameworkTables.MusicIndustryDataSet2();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicIndustryDataSet = new EntityFrameworkTables.MusicIndustryDataSet();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musicIndustryDataSet1 = new EntityFrameworkTables.MusicIndustryDataSet1();
            this.singersTableAdapter = new EntityFrameworkTables.MusicIndustryDataSetTableAdapters.SingersTableAdapter();
            this.songsTableAdapter = new EntityFrameworkTables.MusicIndustryDataSet1TableAdapters.SongsTableAdapter();
            this.songSingersTableAdapter = new EntityFrameworkTables.MusicIndustryDataSet2TableAdapters.SongSingersTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinematographyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinematographyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreFilmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinematographyDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songSingersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndustryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndustryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndustryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.filmsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn3.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Director";
            this.dataGridViewTextBoxColumn4.HeaderText = "Director";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // filmsBindingSource
            // 
            this.filmsBindingSource.DataMember = "Films";
            this.filmsBindingSource.DataSource = this.cinematographyDataSet;
            // 
            // cinematographyDataSet
            // 
            this.cinematographyDataSet.DataSetName = "CinematographyDataSet";
            this.cinematographyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView2.DataSource = this.genresBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(454, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this.cinematographyDataSet1;
            // 
            // cinematographyDataSet1
            // 
            this.cinematographyDataSet1.DataSetName = "CinematographyDataSet1";
            this.cinematographyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmsTableAdapter
            // 
            this.filmsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genreIdDataGridViewTextBoxColumn,
            this.filmIdDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.genreFilmsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 324);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(454, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "Genre_Id";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "Genre_Id";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            this.filmIdDataGridViewTextBoxColumn.DataPropertyName = "Film_Id";
            this.filmIdDataGridViewTextBoxColumn.HeaderText = "Film_Id";
            this.filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            // 
            // genreFilmsBindingSource
            // 
            this.genreFilmsBindingSource.DataMember = "GenreFilms";
            this.genreFilmsBindingSource.DataSource = this.cinematographyDataSet2;
            // 
            // cinematographyDataSet2
            // 
            this.cinematographyDataSet2.DataSetName = "CinematographyDataSet2";
            this.cinematographyDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreFilmsTableAdapter
            // 
            this.genreFilmsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIdDataGridViewTextBoxColumn,
            this.singerIdDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.songSingersBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(473, 325);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(454, 150);
            this.dataGridView4.TabIndex = 5;
            // 
            // songIdDataGridViewTextBoxColumn
            // 
            this.songIdDataGridViewTextBoxColumn.DataPropertyName = "Song_Id";
            this.songIdDataGridViewTextBoxColumn.HeaderText = "Song_Id";
            this.songIdDataGridViewTextBoxColumn.Name = "songIdDataGridViewTextBoxColumn";
            // 
            // singerIdDataGridViewTextBoxColumn
            // 
            this.singerIdDataGridViewTextBoxColumn.DataPropertyName = "Singer_Id";
            this.singerIdDataGridViewTextBoxColumn.HeaderText = "Singer_Id";
            this.singerIdDataGridViewTextBoxColumn.Name = "singerIdDataGridViewTextBoxColumn";
            // 
            // songSingersBindingSource
            // 
            this.songSingersBindingSource.DataMember = "SongSingers";
            this.songSingersBindingSource.DataSource = this.musicIndustryDataSet2;
            // 
            // musicIndustryDataSet2
            // 
            this.musicIndustryDataSet2.DataSetName = "MusicIndustryDataSet2";
            this.musicIndustryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridView5.DataSource = this.singersBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(473, 169);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(454, 150);
            this.dataGridView5.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn9.HeaderText = "Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // singersBindingSource
            // 
            this.singersBindingSource.DataMember = "Singers";
            this.singersBindingSource.DataSource = this.musicIndustryDataSet;
            // 
            // musicIndustryDataSet
            // 
            this.musicIndustryDataSet.DataSetName = "MusicIndustryDataSet";
            this.musicIndustryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11});
            this.dataGridView6.DataSource = this.songsBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(473, 13);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(454, 150);
            this.dataGridView6.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn11.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataMember = "Songs";
            this.songsBindingSource.DataSource = this.musicIndustryDataSet1;
            // 
            // musicIndustryDataSet1
            // 
            this.musicIndustryDataSet1.DataSetName = "MusicIndustryDataSet1";
            this.musicIndustryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singersTableAdapter
            // 
            this.singersTableAdapter.ClearBeforeFill = true;
            // 
            // songsTableAdapter
            // 
            this.songsTableAdapter.ClearBeforeFill = true;
            // 
            // songSingersTableAdapter
            // 
            this.songSingersTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Initial Creation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Create);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinematographyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinematographyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreFilmsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinematographyDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songSingersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndustryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndustryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicIndustryDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private CinematographyDataSet cinematographyDataSet;
        private System.Windows.Forms.BindingSource filmsBindingSource;
        private CinematographyDataSetTableAdapters.FilmsTableAdapter filmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CinematographyDataSet1 cinematographyDataSet1;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private CinematographyDataSet1TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private CinematographyDataSet2 cinematographyDataSet2;
        private System.Windows.Forms.BindingSource genreFilmsBindingSource;
        private CinematographyDataSet2TableAdapters.GenreFilmsTableAdapter genreFilmsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private MusicIndustryDataSet musicIndustryDataSet;
        private System.Windows.Forms.BindingSource singersBindingSource;
        private MusicIndustryDataSetTableAdapters.SingersTableAdapter singersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private MusicIndustryDataSet1 musicIndustryDataSet1;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private MusicIndustryDataSet1TableAdapters.SongsTableAdapter songsTableAdapter;
        private MusicIndustryDataSet2 musicIndustryDataSet2;
        private System.Windows.Forms.BindingSource songSingersBindingSource;
        private MusicIndustryDataSet2TableAdapters.SongSingersTableAdapter songSingersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn singerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button1;
    }
}