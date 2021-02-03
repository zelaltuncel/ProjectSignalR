using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSignalR.Models.ORM.Entities
{
    public class AdminUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string ConnectionID { get; set; }
        public string OnlineStatus { get; set; }
    }
}
