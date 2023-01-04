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
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            /* builder.HasDiscriminator<char>("PassengerType")// entre <> nhotou el type mta3 el colonne w entre ("") el esm mta3 el colonne eli ta3ref biha chnowa el naw3 bethabt  
                  .HasValue<Passenger>('P') ta3ti valeur lezma compatible m3a el type entre<> fl star louwel bch ki ta9ra les donnes ml database tefhem el type chnowa 
                  .HasValue<Traveller>('T')
                  .HasValue<Staff>('S');*/
            builder.HasDiscriminator<int>("IsTraveller")
                 .HasValue<Passenger>(0)
                 .HasValue<Traveller>(1)
                 .HasValue<Staff>(2);
        }
    }
}
