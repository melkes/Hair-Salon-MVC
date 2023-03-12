using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string Name { get; set; }
    // // Do I need something like this?
    // public List<Client> Clients { get; set; } 
  }

}