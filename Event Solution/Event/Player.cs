using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    internal class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public override string ToString() => $"{Name}, {Team}";
        public void Run(Location location) => Console.WriteLine($"{this} is running to towards {location} ");
        
    }
}
