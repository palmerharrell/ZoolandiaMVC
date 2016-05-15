using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace ZoolandiaMVC.Models
{
  public static class SeedData
  {

    // This deosn't work
    private static int _getHtId(string name, ApplicationDbContext context)
    {
      return (from ht in context.HabitatType
                     where ht.name == name
                     select new HabitatType())
                    .ToList()[0].ID;
    }

    public static void Initialize(IServiceProvider serviceProvider)
    {
      var context = serviceProvider.GetService<ApplicationDbContext>();

      if (context.Database == null)
      {
        throw new Exception("DB is null");
      }

      // Seed HabitatType
      if (context.HabitatType.Any())
      {
        return;   // DB has been seeded
      }

      context.HabitatType.AddRange(
        new HabitatType
        {
          name = "Prairie"
        },

        new HabitatType
        {
          name = "Indoor Tank"
        },

        new HabitatType
        {
          name = "Desert"
        }
      );
      context.SaveChanges();

      // Seed Habitat
      if (context.Habitat.Any())
      {
        return;   // DB has been seeded
      }

      context.Habitat.AddRange(
        new Habitat
        {
          name = "Horse Field",
          open = true,
          IdHabitatType = 1 // How can this be found?
        },

        new Habitat
        {
          name = "Frog House",
          open = true,
          IdHabitatType = 1
        },
        
        new Habitat
        {
          name = "Hamster Hut",
          open = true,
          IdHabitatType = 1
        }
      );
      context.SaveChanges();

      // Seed Genus
      if (context.Genus.Any())
      {
        return;   // DB has been seeded
      }

      context.Genus.AddRange(
        new Genus
        {
          scientificName = "Cricetulus"
        },

        new Genus
        {
          scientificName = "Equus"
        },

        new Genus
        {
          scientificName = "Rana"
        }
      );
      context.SaveChanges();

      // Seed Species
      if (context.Species.Any())
      {
        return;   // DB has been seeded
      }

      context.Species.AddRange(
        new Species
        {
          IdGenus = 1, // Fix later
          commonName = "Horse",
          scientificName = "Equus ferus",
          url = "https://en.wikipedia.org/wiki/Wild_horse"
        },

        new Species
        {
          IdGenus = 1,
          commonName = "Chinese Hamster",
          scientificName = "Cricetulus griseus",
          url = "https://en.wikipedia.org/wiki/Chinese_hamster"
        },

        new Species
        {
          IdGenus = 1,
          commonName = "Northern red-legged frog",
          scientificName = "Rana aurora",
          url = "https://en.wikipedia.org/wiki/Northern_red-legged_frog"
        }
      );
      context.SaveChanges();

      // Seed Employee
      if (context.Employee.Any())
      {
        return;   // DB has been seeded
      }

      context.Employee.AddRange(
        new Employee
        {
          name = "Applejack",
          age = 52
        },

        new Employee
        {
          name = "Bob Maplethorpe",
          age = 27
        },

        new Employee
        {
          name = "Kumar",
          age = 48
        }
      );
      context.SaveChanges();

    }
  }
}
