using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServicePlane : IService<Plane>
    {
        public List<Passenger> GetPassengers(Plane plane);
        public List<IGrouping<int, Flight>> GetFlights(int n);
        public bool AvailablePlane(Flight flight, int n);
        public void DeletePlanes();
       
    }
}
