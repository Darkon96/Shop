using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Interface
{
    public interface IAllCakes
    {   
        //изделие
        IEnumerable<Cake> Cakes { get; }
        // категрия популярные товары, для отображения на главной странице сайта
        IEnumerable<Cake> getFavCakes { get; }
        Cake getObjectCake(int cakeId);
    }
}
