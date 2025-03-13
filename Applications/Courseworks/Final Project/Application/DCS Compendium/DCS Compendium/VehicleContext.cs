using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS_Compendium
{
    internal class VehicleContext : DbContext
    {
        //creates table in the DB
        public DbSet<VehicleDBSetup> Vehicles { get; set; }
        

        //connects
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { //database name is DCSVehicles
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DCSVehicles;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        // starting (seed) data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleDBSetup>().HasData(
                new VehicleDBSetup { VehicleID = 1, VehicleName = "SA-3 Goa", VehicleType = "Anti-Air", VehicleClass = "Ground", VehicleImagePath = "Resources\\SA-3 Goa.png", VehicleWeakness = "Chaff, Terrain, Notching", VehicleDescription = "Russian Anti-Air Platform with no self radar, but uses radar from external sources to be guided." },
                new VehicleDBSetup { VehicleID = 2, VehicleName = "SA-6 Kub", VehicleType = "Anti-Air", VehicleClass = "Ground", VehicleImagePath = "Resources\\SA-6 Kub.jpg", VehicleWeakness = "Chaff, Terrain, Notching", VehicleDescription = "Russian Anti-Air Vehicle with a SARH system." },
                new VehicleDBSetup { VehicleID = 3, VehicleName = "SA-8 OSA", VehicleType = "Anti-Air", VehicleClass = "Ground", VehicleImagePath = "Resources\\SA-8 OSA.jpg", VehicleWeakness = "Chaff, Terrain, Notching", VehicleDescription = "Amphibious Russian Wheeled Anti-Air Vehicle with SARH radar." },
                new VehicleDBSetup { VehicleID = 4, VehicleName = "SA-9 Strela", VehicleType = "Anti-Air", VehicleClass = "Ground", VehicleImagePath = "Resources\\SA-9 Strela.png", VehicleWeakness = "Flares", VehicleDescription = "Russian short-range wheeled Anti-Air system." },
                new VehicleDBSetup { VehicleID = 5, VehicleName = "SA-19 Tunguska", VehicleType = "Anti-Air", VehicleClass = "Ground", VehicleImagePath = "Resources\\SA-19 Tunguska.png", VehicleWeakness = "Chaff, Terrain, Notching", VehicleDescription = "Russian Anti-Air Vehicle with 30mm cannons and Anti-Air Missiles." }

                );
            // https://odin.tradoc.army.mil/WEG/Asset/S-125_Neva::Pechora_(SA-3_Goa)_Russian_6x6_Surface-to-Air_Missile_System for military vehicle details
        }

    }
}
