using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoolandiaMVC.Models
{
  public class AnimalDetails
  {
    public int ID { get; set; }
    public string animalName { get; set; }
    public int animalAge { get; set; }
    public string animalSpecies { get; set; }
    public string speciesCommonName { get; set; }
    public string animalHabitat { get; set; }
  }
}
