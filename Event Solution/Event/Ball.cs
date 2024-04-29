using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Ball
    {
        public int Id { get; set; }
		private Location ballLocation;

		public Location BallLocation
        {
			get =>ballLocation; 
			set
			{
				if (value !=  ballLocation)
				{
					OnLocationChanged.Invoke(value);
				}
			}
		}

		public event Action<Location> OnLocationChanged;

		public override string ToString() => $"Id : {Id}, BallLocation : {BallLocation}";

    }
}
