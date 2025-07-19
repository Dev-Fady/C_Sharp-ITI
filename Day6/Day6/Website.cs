using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Website
    {
        public event Action<object,PlayerAddedEventArgs> Playercom;
        public void AddPlayer()
        {
            var dateAdded = DateTime.Now;
            Playercom(this,new PlayerAddedEventArgs { 
                PlayerName = "fadyyyy",
                ClubName = "TOTOTOTOTO",
                DateAdded = dateAdded });
        }
        //protected virtual void OnPlayerAdded(PlayerAddedEventArgs e)
        //{
        //    PlayerAdded?.Invoke(this, e);
        //}
    }
}
