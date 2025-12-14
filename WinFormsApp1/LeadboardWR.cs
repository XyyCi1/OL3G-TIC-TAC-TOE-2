using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class LeadboardWR
    {


        public string Username { get; set; }
        public int Wins { get; set; }
        public int MatchCount { get; set; }

    
        public double WinRate => MatchCount > 0 ? (double)Wins / MatchCount : 0;
    }
}
