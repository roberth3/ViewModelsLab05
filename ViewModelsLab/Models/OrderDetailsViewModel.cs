using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModelsLab.Models
{
    public class OrderDetailsViewModel
    {
        [DisplayName("Order Number")]
        public int Id { get; set; }

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [DisplayName("Order Items")]
        public List<string> OrderLineItem { get; set; }

        [DisplayName("Total Cost")]
        public string Total { get; set; }
    }
}