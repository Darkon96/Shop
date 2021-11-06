using Shop.Date.Interface;
using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.mocks
{
    public class MockCategory : ICakesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Торты", desc = "Торт, лучший подарок на любой праздник!" },
                    new Category { categoryName = "Пироги", desc = "Наши пироги самое вкусные на свете!"}
                };
            }
        }
    }
}
