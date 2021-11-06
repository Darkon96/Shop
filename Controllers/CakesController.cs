using Microsoft.AspNetCore.Mvc;
using Shop.Date.Interface;
using Shop.Date.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CakesController : Controller
    {
        private readonly IAllCakes _allCakes;
        private readonly ICakesCategory _allCategories;

        public CakesController(IAllCakes iAllCakes, ICakesCategory iCakeCat)
        {
            _allCakes = iAllCakes;
            _allCategories = iCakeCat;
        }
       
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Cake> cakes = null;
            string cakeCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cakes = _allCakes.Cakes.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("cakee", category, StringComparison.OrdinalIgnoreCase))
                {
                    cakes = _allCakes.Cakes.Where(i => i.Category.categoryName.Equals("Торты")).OrderBy(i => i.id);
                }
                

                
            }
            var cakeObj = new CakesListViewModel
            {
                AllCakes = cakes,
                cakeCategory = cakeCategory
            };

            ViewBag.Title = "Страница с тортиками";
            
            return View(cakeObj);
        }
    }
}
