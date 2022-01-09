using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Song
{
    
    public partial class Form1 : Form
    {
        
        List<Song> songs;
        Playlist playlist;
        Player player;
        public Form1()
        {
            InitializeComponent();
            playlist = new Playlist();
            player = new Player();
            
            songs = new List<Song>();
            
        }

        WMPLib.WindowsMediaPlayer riproduttore = new WMPLib.WindowsMediaPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            songs.Add(new Song("AAA", 5));
            songs.Add(new Song("BBB", 10));
            songs.Add(new Song("CCC", 3));
            songs.Add(new Song("DDD", 3));

            BindData();
        }
        private void BindData()
        {
            dgv_song.DataSource = null;
            dgv_song.DataSource = songs;
            dgv_coda.DataSource = null;
            dgv_coda.DataSource = playlist._playlist;

        }

        
        private void btn_aggiungi_Click_1(object sender, EventArgs e)
        {
            player._coda.Enqueue(songs[dgv_song.CurrentCell.RowIndex]);
            playlist._playlist.Add(songs[dgv_song.CurrentCell.RowIndex]);
            BindData();
        }


        private void Add_song()
        {
            songs.Add(new Song(txt_titolo.Text, int.Parse(txt_durata.Text)));
        }
        private void btn_aggiungi_song_Click(object sender, EventArgs e)
        {
            Add_song();
            BindData();
        }

        int time = 0;
        int count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;                                 //umento ogni secondo
            btn_play.Text = $"|  |";
            lbl_tempo.Text = time.ToString();       //scrivo nel bottone il tempo

           if (count == player._coda.Count)
           {
                timer1.Stop();
                btn_play.Text = "| >";
                lbl_tempo.Text = "0";
                lbl_quale_canzone.Text = "";
                count = 0;
                playlist._playlist.Clear();
                player._coda.Clear();
                BindData();
           }
           else
           {
                lbl_quale_canzone.Text = $"Stai ascoltando: {player._coda.ElementAt<Song>(count).Title}";
                if (time == player._coda.ElementAt<Song>(count).Duration)
                {
                    time = 0;
                    count++;
                    Rimuovi_Coda();
                    
                }
                
           }

        }

        private void Rimuovi_Coda()
        {
            
            playlist._playlist.RemoveAt(0);
            
            BindData();
        }

        bool controllo = false;
        private void btn_play_Click(object sender, EventArgs e)
        {
            if(controllo==false)
            {
                timer1.Start();
                btn_play.Text = "| |";
                controllo = true;
            }
            else
            {
                timer1.Stop();
                btn_play.Text = "| >";
                controllo = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            riproduttore.URL = @".\mp3\Visiera.Mp3";
            riproduttore.controls.play();
            
        }
    }
}
