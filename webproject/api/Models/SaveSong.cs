using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using api.Models.Interfaces;

namespace api.Models
{
    public class SaveSong : IInsertSong
    {
        public void InsertSong(Song value)
        {
            string cs = ______________;
            using var con = new SQLiteConnection(cs);
            con.open();
            using var cmd = new SQLiteCommand(stm, con);

            cmd.CommandText = @"INSERT INTO songs(songTitle, Artist) Values(@songTitle, @Artist)";
            cmd.Parameters.AddWthValue("@songTitle",songTitle);
            cmd.Parameters.AddWthValue("@Artist", Artist);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        } 
    }
}