using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Models
{
    public class OrderDetails
    {

        /// <summary>
        /// Here the data of order gets categorized and acts as the interfaces with the data base.
        /// This data is related to the order of the user.
        /// </summary>
        [Key]
        public int OrderId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Delevery address is required")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizza name is required")]
        public string PizzaName { get; set; }

        public string PizzaName1 { get; set; }

        public string PizzaName2 { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Crusting is required")]
        public string Crusting { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Toppings if required")]
        public string Toppings { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Number of slices to be made is required")]
        public int Slices { get; set; }

        public int PizzaId { get; set; }

        public List<PizzaDetails> PizzaDetails { get; set; }
    }
}
