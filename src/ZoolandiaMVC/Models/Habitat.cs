using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoolandiaMVC.Models
{
  public class Habitat
  {
    public int ID { get; set; }
    public int IdHabitat { get; set; }
    public int IdHabitatType { get; set; }
    public string name { get; set; }
    public bool open { get; set; }
  }
}
