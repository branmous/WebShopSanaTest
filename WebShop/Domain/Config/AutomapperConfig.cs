﻿using AutoMapper;
using Domain.Contracts;
using Infraestructure.Model.Model;

namespace Domain.Config
{
    public class AutomapperConfig
    {
        public static IMapper CreateMapper()
        {
            var config = CreateConfiguration();
            return config.CreateMapper();
        }

        public static MapperConfiguration CreateConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductContract>().ReverseMap();
            });

            return config;
        }
    }
}
