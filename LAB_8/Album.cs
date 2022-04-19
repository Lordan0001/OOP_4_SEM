using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_shop
{
   public class Album
    {
       public string SongName { get; set; }
        public string SongDuration { get; set; }
        public string FromAlbum { get; set; }
        public Album()
        {
            this.SongDuration = "none";
            this.SongName = "none";
            this.FromAlbum = "none";
        }
        public Album(string SongName, string SongDuration, string FromAlbum)
        {
            this.SongName = SongName;
            this.SongDuration = SongDuration;
            this.FromAlbum = FromAlbum;
        }
    }
}
