using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sweets.Models
{
  public class Treat
  {
    public int TreatId { get; set; }

    public string Name { get; set; } 
    public List<FlavorTreat> JointEntities { get; }
    

  }
}