using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ViewModelsLab.Models;
using ViewModelsLab.Domain;
using AutoMapper;
using ViewModelsLab.Mapping;

namespace ViewModelUnitTest
{
    [TestClass]
    public class UserProfileUnitTest
    {
        [TestMethod]
        public void ConfigureTest()
        {
            // Complex model
            var customer = new Customer
            {
                Name = "George Costanza"
            };
            var order = new Order
            {
                Customer = customer,
                id = 0
            };
            var bosco = new Product
            {
                Name = "Bosco",
                Price = 4.99m
            };
            order.AddOrderLineItem(bosco, 15);

            AutoMapperConfiguration.Configure();

            // Configure AutoMapper
            OrderDetailsViewModel dto = Mapper.Map<Order, OrderDetailsViewModel>(order);

            //Assert
            Assert.AreEqual("George Costanza", dto.CustomerName, "Customer name doesn't match");
            Assert.AreEqual("£74.85", dto.Total, "Total does not match");
            Assert.AreEqual(dto.OrderLineItem[0], "Bosco: Quantity - 15", "Order Line item Does not match");

        }
    }
}
