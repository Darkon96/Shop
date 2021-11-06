using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class CakesListViewModel
    {
        public IEnumerable<Cake> AllCakes { get; set; }

        public string cakeCategory { get; set; }
    }
}
