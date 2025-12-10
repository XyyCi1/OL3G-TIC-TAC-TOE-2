using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace WinFormsApp1
{
 

        public class UserAccount
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }

            [Unique]
            public string Username { get; set; }

            public string Password { get; set; }   
             public int Wins { get; set; }

    }
    
}
