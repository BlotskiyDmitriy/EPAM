﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Task5.BLL.DTO;
using Task5.DAL.Entities;

namespace Task5.BLL.Extentions
{
    public static class MapperHelper
    {
        private static MapperConfiguration _config;
        private static Mapper _mapper;

        public static Mapper Mapper => _mapper;

        public static MapperConfiguration Config => _config;

        public static void MapperConfig()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientDTO>();
                cfg.CreateMap<Product, ProductDTO>();
                cfg.CreateMap<Order, OrderDTO>()
                .ForMember(x => x.Client, y => y.MapFrom(x => x.Client.Name))
                .ForMember(x => x.Product, y => y.MapFrom(x => x.Product.Name));

                cfg.CreateMap<ClientDTO, Client>();
                cfg.CreateMap<ProductDTO, Product>();
                cfg.CreateMap<OrderDTO, Order>()
                .ForPath(x => x.Client.Name, y => y.MapFrom(x => x.Client))
                .ForPath(x => x.Product.Name, y => y.MapFrom(x => x.Product));

            });

            _mapper = new Mapper(_config);

        }
    }
}
