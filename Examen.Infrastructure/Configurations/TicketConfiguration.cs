using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
       
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new { t.FlightFK, t.PassengerFK });// key composé ml foreign keys mta3 passenger w flight

            //one to many m3a el Flight
            builder.HasOne(t => t.Flignt)
               .WithMany(f => f.Tickets)//withMany tdakhalni ll classe lokhra(Flight) donc nhot esm el liste eli fiha mta3 el tickets 
               .HasForeignKey(t => t.FlightFK);// taffecti el foreign key chnowa bethabt 
            //one to Many m3a El Passenger
            builder.HasOne(t => t.Passenger)
              .WithMany(p => p.Tickets)//withMany tdakhalni ll classe lokhra(Flight) donc nhot esm el liste eli fiha mta3 el tickets
              .HasForeignKey(t => t.PassengerFK);
        }
    }
}
