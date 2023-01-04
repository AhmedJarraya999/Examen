using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Ticket// hethy table porteuse de donneés . many to many twali one to many ml chirtin m3a hethy 
        //fiha des donnes zeydin al foreignkeys mta3 flight w passenger eli houma ( prix , siege , vip ) 
    {
        public double Prix { get; set; }
        public int Siege { get; set; }
        public bool VIP { get; set; }
        public virtual string PassengerFK { get; set; }// hethy bch nsta3mlouha foreignKey . lezem nafs el type mta3 el Key mta3 el passenger 
        public virtual Passenger Passenger { get; set; }//prop de navigation ( one to many )
        public virtual int FlightFK { get; set; }// hethy bch nsta3mlouha foreignKey . lezem nafs el type mta3 el Key mta3 el flight
        public virtual Flight Flignt { get; set; }//prop de navigation ( one to many )

    }
}
