using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollabrApi.Models
{
    public class Profile
    {
        private long UserId { get; set; }
        private string AvatarPicturePath { get; set; }
        private string SongOnePath { get; set; }
        private string SongTwoPath { get; set; }
        private string SongThreePath { get; set; }
        private List<string> Genres { get; set; }
    }
}
