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
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            //Many to Many ma3adech khater walet 3ana table porteuse de donnees donc maach many to many 
            ////builder.HasMany(f => f.Passengers).WithMany(p => p.Flights) 
            ////        .UsingEntity(t => t.ToTable("Reservation")); hethy bch tbadel esm el table d'association kif matheb enty 

            //One To Many 
            builder.HasOne(f => f.Plane).WithMany(p => p.Flights)
                .HasForeignKey(f => f.PlaneFk)
                .OnDelete(DeleteBehavior.ClientSetNull); // hethy trod el attribut plane fl flight null fi souret fasakhna el plane athika bzhar 

        }
    }
}
