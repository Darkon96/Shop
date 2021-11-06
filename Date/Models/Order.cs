using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Date.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Имя")]
        [StringLength(10)]
        [Required(ErrorMessage ="Длинна имени менее 5 символов")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длинна фамилии менее 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(30)]
        [Required(ErrorMessage = "Длинна введённого вами адреса менее 15 символов")]
        public string adress { get; set; }

        [Display(Name = "Телефон")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длинна номера телефона менее 10 символов")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(30)]
        [Required(ErrorMessage = "Длинна email менее 15 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
