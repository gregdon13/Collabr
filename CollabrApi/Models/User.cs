using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollabrApi.Models
{
    public class User
    {
        private long ID { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        // recommend using artist name vvv
        private string UserName { get; set; }
        private string Password { get; set; }
        private DateTime Birthday { get; set; }
        private string Email { get; set; }
        private List<long> Matches { get; set; }
    }
}
