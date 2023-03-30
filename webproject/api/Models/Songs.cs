using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace api.Models
{
    public class Song
    {
        public Guid songID { get; set; }
        public string songTitle { get; set; }
        public string Artist { get; set; }
        public DateTime dateAdded { get; set; }
        public bool Favorite {get; set;}
        public bool Deleted {get; set;}

    public Song()
    {
        songID = Guid.NewGuid();
        dateAdded = DateTime.Now;
        Favorite = false;
        Deleted = false;
    }

    public string ToString()
    {
        return songTitle + "\nID: " + songID.ToString() + "\nArtist: " + Artist.ToString() + "\nDate Added: " + dateAdded.ToString();
    }
    }
}
