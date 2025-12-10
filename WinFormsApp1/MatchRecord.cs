using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class MatchRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Username { get; set; }  
        public string Opponent { get; set; }   
        public string Result { get; set; }     
        public DateTime DatePlayed { get; set; }
    }
}
