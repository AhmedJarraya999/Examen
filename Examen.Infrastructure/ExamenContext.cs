using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure
{
    public class ExamenContext: DbContext
    {
      //  public DbSet<Exemple> Exemples { get; set; }
      //nektbou les dbsets lkol ken el classe mta3 el table porteuse de donneés 
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();// bch ta3ref tjeri les ressources w a9al wa9t d'execution 
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=ExamenDB;Integrated Security=true");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { //methode njibouha ml DbContext biha njmou nsta3mlou les config eli 3amlinhom fl Configurations fl Bd Mta3na 
          //si nn ytchefouch 
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());


            //ken habina nasn3ou kol lkol classe teb3a l'heritage une table wahadha fl database na3mlou athouma 
            //modelBuilder.Entity<Staff>().ToTable("Staffs"); // to table tasna3 el table w tasamiha ama ken masnou3a tbalelha esmha wkhw 
            //modelBuilder.Entity<Traveller>().ToTable("Travellers");

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        }

    }
}