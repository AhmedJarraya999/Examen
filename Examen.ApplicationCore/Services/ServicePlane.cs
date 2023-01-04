using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServicePlane : Service<Plane>, IServicePlane
    {
        public ServicePlane(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public bool AvailablePlane(Flight flight, int n)
        {
            int capacity = Get(p=>p.Flights.Contains(flight) == true).Capacity;
            int nbPassengers = flight.Tickets.Count();
            return capacity >= (nbPassengers + n);
            
        }

        public void DeletePlanes()
        {
           foreach(var plane in GetAll().Where(p=> ( DateTime.Now - p.ManufactureDate).TotalDays >365*10).ToList()) 
            {
                Delete(plane);
                Commit();
            }
        }

        public List<IGrouping<int, Flight>> GetFlights(int n)
        {
            return GetAll().OrderByDescending(p => p.PlaneId).Take(n).SelectMany(p=>p.Flights)
                .GroupBy(f=>f.Plane.PlaneId).ToList();
        }

        public List<Passenger> GetPassengers(Plane plane)
        {
            return GetById(plane.PlaneId).Flights.SelectMany(f=>f.Tickets.Select(t=>t.Passenger)).ToList(); 
        }
    }
}
