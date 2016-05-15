﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZoolandiaMVC.Models
{
  public class Species
  {
    public int ID { get; set; }
    public int IdSpecies { get; set; }
    public int IdGenus { get; set; }
    public string url { get; set; }
    public string scientificName { get; set; }
    public string commonName { get; set; }
  }
}
