using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }

        //prop de navigation 
        //public virtual List<Passenger> Passengers { get; set; } ya hasra kona many to many m3a passengers taw 
        //one to many m3a el ticket 
        public virtual  List<Ticket> Tickets { get; set; }
        public virtual Plane Plane { get; set; }//prop de navigation 
        [ForeignKey("Plane")]// hethy affectina biha el planeFK eli hiya foreignkey ll plane fl flight . plane eli west el parenthese esm lclasse eli fi relation m3a el flight 
        public virtual int PlaneFk { get; set; }//hethy bch nsta3mlouha foreignkey ll plane . lezem nafs el type hiya wl key mta3 lplane 


    }
}
