using System.Collections.Generic;
using WindowsFormsApp.Model;

namespace WindowsFormsApp.Repositories
{
    public class FuelRepository
    {

        public List<FuelInfo> Get()
        {
            return new List<FuelInfo>()
            {
                new FuelInfo() {Name = "АИ-92", Price = 1.70m},
                new FuelInfo() {Name = "АИ-95", Price = 1.80m},
                new FuelInfo() {Name = "Super-98", Price = 2.02m},
            };
        }

    }
}
