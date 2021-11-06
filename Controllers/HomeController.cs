using Microsoft.AspNetCore.Mvc;
using Shop.Date.Interface;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllCakes _cakeRep;
        public HomeController(IAllCakes cakeRep)
        {
            _cakeRep = cakeRep;
        }
        public ViewResult Index()
        {
            var homeCakes = new HomeViewModel
            {
                favCakes = _cakeRep.getFavCakes
            };
            return View(homeCakes);
        }
    }
}
