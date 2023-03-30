using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using api.Models.Interfaces;

namespace api.Models
{
    public class ReadSongData : IGetAllSongs , IGetSong
    {
        public List<Song> GetAllSongs()
        {
            string cs = @"C:\Users\Owner\Desktop\MIS321\PAs\pa3\njbartle-pa3-spring23\webproject\api\song.db";
            using var con = new SQLiteConnection(cs);
            con.open();

            string stm = "SELECT * FROM SONGS";
            using var cmd = new SQLiteCommand(stm, con);

            using SQLiteDataReader rdr = cmd.ExecuteReader();

            List<Song> allSongs = new List<Song>();
            while(rdr.read())
            {
                allSongs.Add(new Song(){songID = rdr.getInt32(0), songTitle = rdr.getString(1), Artist = rdr.getString(2),});
            }
            return allSongs;
        }

        public Song GetSong(int songID)
        {
            string cs = ______________;
            using var con = new SQLiteConnection(cs);
            con.open();

            string stm = "SELECT * FROM SONGS WHERE songID = @songID";
            using var cmd = new SQLiteCommand(stm, con);
            cmd.Parameters.AddWthValue("@songID",songID);
            cmd.Prepare();
            using SQLiteDataReader rdr = cmd.ExecuteReader();

            rdr.Read();
            return new Song(){songID = rdr.getInt32(0), songTitle = rdr.getString(1), Artist = rdr.getString(2)};



        }
        
    }
}