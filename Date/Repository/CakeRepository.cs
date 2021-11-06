using Shop.Date.Interface;
using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Shop.Date.Repository
{

    public class CakeRepository : IAllCakes
        {
            private readonly AppDBContent appDBContent;

            public CakeRepository(AppDBContent appDBContent)
            {
                this.appDBContent = appDBContent;
            }
        //связь с базой данных по обьектам Cakes и FavCakes
        public IEnumerable<Cake> Cakes => appDBContent.Cake.Include(c => c.Category);

        public IEnumerable<Cake> getFavCakes => appDBContent.Cake.Where(p => p.isFavourite).Include(c => c.Category);

        public Cake getObjectCake(int cakeId) => appDBContent.Cake.FirstOrDefault(p => p.id == cakeId);
            
        }
    
}

