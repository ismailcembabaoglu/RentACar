﻿using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RentACar.Application.DTOs;
using RentACar.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Persistence.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });
            IMapper mapper=mappingConfig.CreateMapper();
            service.AddSingleton(mapper);
            return service;
        }
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            CreateMap<Car, CarDTO>().ForMember(c=>c.CarNameModel,y=>y.MapFrom(y=>y.CarName+y.CarModel));
            CreateMap<CarDTO, Car>();

            CreateMap<CarLocation, CarLocationDTO>()
                .ForMember(c => c.CarName,y=>y.MapFrom(y=>y.Car.CarName))
                .ForMember(c=>c.CarModel,y=>y.MapFrom(y=>y.Car.CarModel))
                .ForMember(c=>c.City,y=>y.MapFrom(y=>y.Location.City))
                .ForMember(c=>c.LocationDescription,y=>y.MapFrom(y=>y.Location.Decription));
            CreateMap<CarLocationDTO, CarLocation>();

            CreateMap<CarOption, CarOptionDTO>()
                .ForMember(c => c.CarName, y => y.MapFrom(y => y.Car.CarName))
                .ForMember(c=>c.CarModel,y=>y.MapFrom(y=>y.Car.CarModel))
                .ForMember(c=>c.OptionName,y=>y.MapFrom(y=>y.Option.OpsiyonName))
                .ForMember(c=>c.OptionPrice,y=>y.MapFrom(y=>y.Option.OpsiyonPrice));
            CreateMap<CarOptionDTO, CarOption>();
        }
    }

}
