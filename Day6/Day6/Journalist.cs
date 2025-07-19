using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Journalist 
    {
        internal void PlayereAdded(PlayerAddedEventArgs playerAdded)
        {
            Console.WriteLine($"Journalist: Player {playerAdded.PlayerName} added to {playerAdded.ClubName} {playerAdded.DateAdded.Month}.");
        }
       
    }
}
