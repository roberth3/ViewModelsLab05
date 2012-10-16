using System;
using System.Linq;
using AutoMapper;
using ViewModelsLab.Domain;
using ViewModelsLab.Models;

namespace ViewModelsLab.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new OrderProfile());
            });
        }
    }

    public class OrderProfile : Profile
    {
        protected override void Configure()
        {
            // can map by convention as property names match
            //Mapper.CreateMap<OrderDetailsViewModel, Order>();

           // Mapper.CreateMap<OrderLineItem, string>();
            Mapper.CreateMap<OrderLineItem, string>().ConvertUsing(item => item.Product.Name + ": Quantity - " + item.Quantity.ToString());

            // can map explicitly using fluent specification
            // all properties mapped for illustration, actually only really need to specify 
            // price in this example as other properties could be mapped by convention
            Mapper.CreateMap<Order, OrderDetailsViewModel>()
                   .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src => src.id))
                    .ForMember(dest => dest.CustomerName,
                    opt => opt.MapFrom(src => src.Customer.Name))
                    .ForMember(dest => dest.OrderLineItem,
                    opt => opt.MapFrom(src => src.OrderLineItems))
                    .ForMember(dest => dest.Total,
                    opt => opt.MapFrom(src => String.Format("{0:c}", src.GetTotal())));

        }


    }


    //.ForMember(dest => dest.OrderLineItem, opt => 
    //                     {   
    //                        opt.ResolveUsing<OrderLineResolver>().FromMember(src => src.OrderLineItems);   
    //                    })
    //public class OrderLineResolver : ValueResolver<OrderLineItem, string>
    //{

    //    protected override string ResolveCore(OrderLineItem source)
    //    {
    //        return source.Product + ": Quantity - " + source.Quantity.ToString();
    //    }
    //}

}