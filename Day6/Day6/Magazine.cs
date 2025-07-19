using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Magazine
    {
        internal void NewPlayerAdded(PlayerAddedEventArgs playerAdded)
        {
            Console.WriteLine($"Magazine: New player {playerAdded.PlayerName} added to the {playerAdded.ClubName} {playerAdded.DateAdded.TimeOfDay}.");
        }
    }
}
