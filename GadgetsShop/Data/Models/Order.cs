using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevicesShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Enter name")]
        [Required(ErrorMessage = "Please, enter your name")]
        public string FirstName { get; set; }

        [Display(Name = "Enter lastname")]
        [Required(ErrorMessage = "Please, enter your lastname")]
        public string LastName { get; set; }

        [Display(Name = "Enter adress")]
        [Required(ErrorMessage = "Please, enter your adress")]
        public string Adress { get; set; }

        [Display(Name = "Enter number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please, enter your number")]
        public string Phone { get; set; }

        [Display(Name = "Enter name")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please, enter your email")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
