using CatAndDogServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace CatAndDogServer.Data
{
    public class DataContext : DbContext //, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<PetOwner> PetOwners { get; set; }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Cat> Cats { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        //public async Task SaveChangesAsync()
        //{
        //    await this.SaveChangesAsync();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region DogSeed
            modelBuilder.Entity<Dog>().HasData(
                new Dog { Id = 1, DatumNarodenia = new DateTime(2011, 1, 15), PetOwnerId = 1, PocetKrmeni = 2, Name = "Dog xY", PocetUhriznuti = 3 },
                new Dog { Id = 2, DatumNarodenia = new DateTime(2012, 3, 16), PetOwnerId = 1, PocetKrmeni = 3, Name = "Dog xY", PocetUhriznuti = 3 },
                new Dog { Id = 3, DatumNarodenia = new DateTime(2013, 5, 12), PetOwnerId = 1, PocetKrmeni = 1, Name = "Dog 5Y", PocetUhriznuti = 3 },
                new Dog { Id = 4, DatumNarodenia = new DateTime(2017, 9, 5), PetOwnerId = 1, PocetKrmeni = 10, Name = "Dog x6", PocetUhriznuti = 3 },
                new Dog { Id = 5, DatumNarodenia = new DateTime(2015, 10, 8), PetOwnerId = 1, PocetKrmeni = 2, Name = "Dog 4Y", PocetUhriznuti = 3 },
                new Dog { Id = 6, DatumNarodenia = new DateTime(2014, 12, 7), PetOwnerId = 1, PocetKrmeni = 5, Name = "Dog 8Y", PocetUhriznuti = 3 },
                new Dog { Id = 7, DatumNarodenia = new DateTime(2011, 11, 21), PetOwnerId = 1, PocetKrmeni = 7, Name = "Dog 9Y", PocetUhriznuti = 3 },
                new Dog { Id = 8, DatumNarodenia = new DateTime(2019, 1, 1), PetOwnerId = 1, PocetKrmeni = 8, Name = "Dog x7", PocetUhriznuti = 3 },
                new Dog { Id = 9, DatumNarodenia = new DateTime(2020, 1, 1), PetOwnerId = 1, PocetKrmeni = 9, Name = "Dog 1Y", PocetUhriznuti = 3 },
                new Dog { Id = 10, DatumNarodenia = new DateTime(2011, 1, 15), PetOwnerId = 1, PocetKrmeni = 10, Name = "Dog a12BS", PocetUhriznuti = 3 },
                new Dog { Id = 11, DatumNarodenia = new DateTime(2012, 3, 16), PetOwnerId = 1, PocetKrmeni = 2, Name = "Dog aa56S", PocetUhriznuti = 3 },
                new Dog { Id = 12, DatumNarodenia = new DateTime(2013, 5, 12), PetOwnerId = 1, PocetKrmeni = 3, Name = "Dog aa45S", PocetUhriznuti = 3 },
                new Dog { Id = 13, DatumNarodenia = new DateTime(2017, 9, 5), PetOwnerId = 1, PocetKrmeni = 5, Name = "Dog aa12S", PocetUhriznuti = 3 },
                new Dog { Id = 14, DatumNarodenia = new DateTime(2015, 10, 8), PetOwnerId = 1, PocetKrmeni = 8, Name = "Dog aaB35", PocetUhriznuti = 3 },
                new Dog { Id = 15, DatumNarodenia = new DateTime(2014, 12, 7), PetOwnerId = 1, PocetKrmeni = 7, Name = "Dog aa458", PocetUhriznuti = 3 }
                );
            #endregion

            #region CatSeed
            modelBuilder.Entity<Cat>().HasData(
                new Cat { Id = 1, DatumNarodenia = new DateTime(2014, 12, 7), PetOwnerId = 1, PocetKrmeni = 1, Name = "Cat 12A", PocetMaciatok = 1 },
                new Cat { Id = 2, DatumNarodenia = new DateTime(2011, 11, 21), PetOwnerId = 1, PocetKrmeni = 2, Name = "Cat 23A", PocetMaciatok = 1 },
                new Cat { Id = 3, DatumNarodenia = new DateTime(2019, 1, 1), PetOwnerId = 1, PocetKrmeni = 3, Name = "Cat A15", PocetMaciatok = 1 },
                new Cat { Id = 4, DatumNarodenia = new DateTime(2020, 1, 1), PetOwnerId = 1, PocetKrmeni = 5, Name = "Cat 15A", PocetMaciatok = 1 },
                new Cat { Id = 5, DatumNarodenia = new DateTime(2011, 1, 15), PetOwnerId = 1, PocetKrmeni = 5, Name = "Cat 118A", PocetMaciatok = 1 },
                new Cat { Id = 6, DatumNarodenia = new DateTime(2012, 3, 16), PetOwnerId = 1, PocetKrmeni = 4, Name = "Cat 135A", PocetMaciatok = 1 },
                new Cat { Id = 7, DatumNarodenia = new DateTime(2014, 12, 7), PetOwnerId = 1, PocetKrmeni = 6, Name = "Cat A1558", PocetMaciatok = 1 },
                new Cat { Id = 8, DatumNarodenia = new DateTime(2011, 11, 21), PetOwnerId = 1, PocetKrmeni = 8, Name = "Cat 1651A", PocetMaciatok = 1 },
                new Cat { Id = 9, DatumNarodenia = new DateTime(2015, 1, 1), PetOwnerId = 1, PocetKrmeni = 7, Name = "Cat A15", PocetMaciatok = 1 },
                new Cat { Id = 10, DatumNarodenia = new DateTime(2014, 12, 7), PetOwnerId = 1, PocetKrmeni = 9, Name = "Cat A115", PocetMaciatok = 1 },
                new Cat { Id = 11, DatumNarodenia = new DateTime(2011, 11, 21), PetOwnerId = 1, PocetKrmeni = 9, Name = "Cat Acd", PocetMaciatok = 1 },
                new Cat { Id = 12, DatumNarodenia = new DateTime(2019, 1, 1), PetOwnerId = 1, PocetKrmeni = 10, Name = "Cat daA", PocetMaciatok = 2 },
                new Cat { Id = 13, DatumNarodenia = new DateTime(2020, 1, 1), PetOwnerId = 1, PocetKrmeni = 11, Name = "Cat cdsaA", PocetMaciatok = 2 },
                new Cat { Id = 14, DatumNarodenia = new DateTime(2011, 1, 15), PetOwnerId = 1, PocetKrmeni = 12, Name = "Cat csaA", PocetMaciatok = 2 },
                new Cat { Id = 15, DatumNarodenia = new DateTime(2012, 3, 16), PetOwnerId = 1, PocetKrmeni = 1, Name = "Cat Acs", PocetMaciatok = 2 }
                );
            #endregion

            #region CatSeed
            modelBuilder.Entity<PetOwner>().HasData(
                new PetOwner { Id = 1, Name = "Chovna stanica", Address = "Osada Plavecky Svrtok" }
                );
            #endregion
        }
    }
}
