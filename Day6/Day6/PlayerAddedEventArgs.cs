using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class PlayerAddedEventArgs
    {
        public string PlayerName { get; set; }
        public string ClubName { get; set; }
        public DateTime DateAdded { get; set; }
        //public PlayerAddedEventArgs(string playerName, string clubName, DateTime dateAdded)
        //{
        //    PlayerName = playerName;
        //    ClubName = clubName;
        //    DateAdded = dateAdded;
        //}
    }
}
