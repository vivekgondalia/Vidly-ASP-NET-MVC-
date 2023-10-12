﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        //Automapper - A Convention Based Mappingn Tool. Uses property name.
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Movie, MovieDto>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<MovieDto, Movie>();
        }
    }
}