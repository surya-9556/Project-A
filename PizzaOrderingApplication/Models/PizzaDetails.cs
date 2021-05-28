using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Models
{
    public class PizzaDetails
    {
        /// <summary>
        /// Here the data of order gets categorized and acts as the interfaces with the data base.
        /// This data is related to the pizza's of the user.
        /// </summary>
        [Key]
        public int PizzaID { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizz Name is required")]
        public string PizzaName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizza size is required")]
        public string PizzaSize { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizza Type is required")]
        public string PizzaType { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizz Specality is required")]
        public string PizzaSecality { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizz Price is required")]
        public double PizzaPrice { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Pizz Image is required")]
        public string PizzaImage { get; set; }
    }
}
