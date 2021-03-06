﻿using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly
{
    public class MappingProfile: Profile
    {

        public MappingProfile() {

            //Domain to Dto

            Mapper.CreateMap<Customer, CustomerDto>();

            Mapper.CreateMap<Movie, MovieDto>();
                
                
            //Dto to Domain

            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(m=>m.Id,opt=>opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m=>m.Id,opt=>opt.Ignore());
                
            
        }
    }
}