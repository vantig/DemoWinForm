
using System.Collections.Generic;
using DemoSimpleControls.Model;

namespace DemoSimpleControls.Repositories
{
  public class FuelRepository
  {

    public List<FuelInfo> Get()
    {
      return new List<FuelInfo>()
      {
        new FuelInfo(){Name = "АИ-92", Price = 1.75m},
        new FuelInfo(){Name = "АИ-95", Price = 1.80m},
        new FuelInfo(){Name = "ДТ Евро", Price = 1.81m},
        
      };
    }

  }
}
