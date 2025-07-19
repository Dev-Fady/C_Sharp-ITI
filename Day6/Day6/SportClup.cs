using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class SportClup
    {

        //public event Action<string,string,DateTime> PlayerAdded;
        public event Action<object, PlayerAddedEventArgs> PlayerAdded;
        List<string> players = new List<string>();
        public string Name { get; set; }
        
        //List<ISubscriber> subscribers = new List<ISubscriber>();

        //public void Subscribe(ISubscriber subscriber)
        //{
        //    if (!subscribers.Contains(subscriber))
        //    {
        //        subscribers.Add(subscriber);
        //        //Console.WriteLine($"{subscriber.Name} subscribed to {Name}.");
        //    }
        //    else
        //    {
        //        //Console.WriteLine($"{subscriber.Name} is already subscribed to {Name}.");
        //    }
        //}

        public virtual void AddPlayer(string player)
        {
            if (!players.Contains(player))
            {
                players.Add(player);
                Console.WriteLine($"Player {player} added to {Name}.");
                //foreach (var item in subscribers)
                //{
                //    item.Notify();
                //}
                if (PlayerAdded != null)
                {
                    PlayerAdded( this,new PlayerAddedEventArgs
                    {
                        PlayerName = player,
                        ClubName = Name,
                        DateAdded = DateTime.Now
                    });
                }
                else
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine($"Player {player} already exists in {Name}.");
            }
        }
    }
}
