using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModelsLab.Models
{
    public class ItemDetailViewDetail
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        //[DisplayName("Product")]
        //public string ProductName { get; set; }

        [Range(0, 100, ErrorMessage =
            "Please enter a number between 1 and 100")]
        [DisplayName("How many")]
        public int OrderLineItemQuantity { get; set; }

        [Required(ErrorMessage = "HEY! - Which Product")]
        [DisplayName("Product")]
        public string OrderLineItemProductName { get; set; }

        public SelectList ProductList { get; set; }
    }
}