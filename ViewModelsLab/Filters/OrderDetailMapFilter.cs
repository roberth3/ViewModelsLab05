using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ViewModelsLab.Domain;
using ViewModelsLab.Models;

namespace ViewModelsLab.Filters
{
    public class OrderDetailMapFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var domain = (Order)filterContext.Controller.ViewData.Model;
            var viewModel = Mapper.Map<Order, OrderDetailsViewModel>(domain);
            filterContext.Controller.ViewData.Model = viewModel;
        }
    }
}