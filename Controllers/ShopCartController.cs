using Microsoft.AspNetCore.Mvc;
using Shop.Date.Interface;
using Shop.Date.Models;
using Shop.ViewModels;
using System.Linq;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllCakes _cakeRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCakes cakeRep, ShopCart shopCart)
        {
            _cakeRep = cakeRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _cakeRep.Cakes.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

    }
}
