using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryResturantData : IResturantData
    {
        private readonly List<Resturant> resturants;
        public InMemoryResturantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant {Id = 1, Name ="Scott's Pizza", Location = "Maryland", Cuisine = CuisineType.Indian},
                new Resturant {Id = 2, Name ="Cinnamon Club", Location = "London", Cuisine = CuisineType.Italian},
                new Resturant {Id = 3, Name ="La Costa", Location = "Paris", Cuisine = CuisineType.Mexican},

            };
        }
        public IEnumerable<Resturant> GetAll() => from r in resturants
                                                  orderby r.Name
                                                  select r;
    }
}
