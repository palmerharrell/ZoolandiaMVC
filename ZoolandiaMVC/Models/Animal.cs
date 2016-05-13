using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZoolandiaMVC.Models
{
  public class Animal
  {
    public int IdAnimal { get; set; }
    public int IdSpecies { get; set; }
    public int IdHabitat { get; set; }
    public string name { get; set; }
    public int age { get; set; }
  }
}
