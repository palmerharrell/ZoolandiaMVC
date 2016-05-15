using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoolandiaMVC.Models
{
  public class Animal
  {
    public int ID { get; set; }
    public int IdAnimal { get; set; }
    public int IdSpecies { get; set; }
    public int IdHabitat { get; set; }
    public string name { get; set; }
    public int age { get; set; }
  }
}
