using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ZoolandiaMVC.Models
{
  public class ZoolandiaContext : DbContext
  {
    public DbSet<Animal> Animal { get; set; }
    public DbSet<Employee> Employee { get; set; }
    public DbSet<Genus> Genus { get; set; }
    public DbSet<Habitat> Habitat { get; set; }
    public DbSet<HabitatEmployees> HabitatEmployees { get; set; }
    public DbSet<HabitatType> HabitatType { get; set; }
    public DbSet<Species> Species { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Animal>().ToTable("Animal").HasKey(a => a.IdAnimal);

      modelBuilder.Entity<Employee>()
        .ToTable("Employee")
        .HasKey(e => e.IdEmployee);

      modelBuilder.Entity<Genus>()
        .ToTable("Genus")
        .HasKey(g => g.IdGenus);

      modelBuilder.Entity<Habitat>()
        .ToTable("Habitat")
        .HasKey(h => h.IdHabitat);

      modelBuilder.Entity<HabitatEmployees>()
        .ToTable("HabitatEmployees")
        .HasKey(he => he.IdHabitatEmployees);

      modelBuilder.Entity<HabitatType>()
        .ToTable("HabitatType")
        .HasKey(ht => ht.IdHabitatType);

      modelBuilder.Entity<Species>()
        .ToTable("Species")
        .HasKey(s => s.IdSpecies);

    }
  }
}