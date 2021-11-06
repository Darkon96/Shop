using Shop.Date.Interface;
using Shop.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.mocks
{
    public class MockCakes : IAllCakes
    {

        private readonly ICakesCategory _categoryCakes = new MockCategory();
        public IEnumerable<Cake> Cakes {
            get
            {
                return new List<Cake>
                {
                    new Cake { 
                        name ="Наполеон", 
                        shortDesc = "Домашний торт из рубленного теста и заварного крема отличается своими вкусовыми особенностями, которые превзойдут все ваши ожидания ", 
                        img = "/img/1.jpg", 
                        price = 1500, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCakes.AllCategories.First() },

                    new Cake {
                        name ="Медовик",
                        shortDesc = "Нежные, тающие во рту медовые коржи, пропитанные воздушным заварным кремом, - незабываемый вкус детства!",
                        img = "/img/2.jpg",
                        price = 1600,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCakes.AllCategories.First() },

                    new Cake {
                        name ="Чизкейк Нью-Йорк",
                        shortDesc = "Чизкейк — классическое блюдо американской кухни, которое прочно вошло в меню кафешек всего мира",
                        img = "/img/3.jpg",
                        price = 2000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCakes.AllCategories.First() },

                    new Cake {
                        name ="Торт Чизкейк с маракуйя",
                        shortDesc = "Свежий сырный чизкейк с тропическим маракуйя. Тонкий песочный корж для основы и плотная сырная масса, покрытая маракуйя с семенами. ",
                        img = "/img/4.jpg",
                        price = 2350,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCakes.AllCategories.First() },

                    new Cake {
                        name ="Морковный торт",
                        shortDesc = "Морковные коржи настолько вкусные, что их можно назвать самостоятельным десертом, но добавив к ним крем мы получили идеал.",
                        img = "/img/5.jpg",
                        price = 2200,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCakes.AllCategories.First() },

                    new Cake {
                        name ="Безе Павлова со свежими ягодами",
                        shortDesc = "Нежное безе Павлова. Этот невероятно легкий десерт - хрустящий снаружи и мягкий внутри. Украшается свежей клубникой, малиной и голубикой.",
                        img = "/img/6.jpg",
                        price = 2200,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCakes.AllCategories.First() },

                    new Cake {
                        name ="Торт-пирог Бруснично-Кремовый",
                        shortDesc = "Венский пирог с брусничной начинкой, белым бельгийским шоколадом, целой брусникой и взбитыми сливками.",
                        img = "/img/7.jpg",
                        price = 2190,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCakes.AllCategories.Last() },


                    new Cake {
                        name ="Пирог вишнёвый",
                        shortDesc = "Вкуснейший пирог с вишней.",
                        img = "/img/8.jpg",
                        price = 1270,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCakes.AllCategories.Last() },


                    new Cake {
                        name ="Пирог с курицей и грибами",
                        shortDesc = "Пирог из воздушного сдобного дрожжевого теста с начинкой из куриного филе, лука и грибов шампиньонов.",
                        img = "/img/9.jpg",
                        price = 168,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCakes.AllCategories.Last() }


                };
             }   
        }
        public IEnumerable<Cake> getFavCakes { get; set; }

        public Cake getObjectCake(int cakeId)
        {
            throw new NotImplementedException();
        }
    }
}
