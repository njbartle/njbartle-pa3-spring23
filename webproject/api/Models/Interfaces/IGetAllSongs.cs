using System.Collections.Generic;

namespace api.Models.Interfaces
{
    public interface IGetAllSongs
    {
        List<Song> GetAllSongs();
    }
}