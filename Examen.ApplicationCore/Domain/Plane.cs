using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        [Range(0, int.MaxValue)] // el int wl double les conditions dima bl Range(valeurmin,valeurmax)
        public int Capacity { get; set; }
        public virtual List<Flight> Flights { get; set; }


        // hetha constructeur paramétré na3mel bih el instantiation mta3 objet plane 
        // el constructeur sans parametre masnou3 par default ama ken nasna3 hetha nwali lezem nasna3 el sans param
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
        public Plane() //sans param
        {
            
        }
    } 
}
