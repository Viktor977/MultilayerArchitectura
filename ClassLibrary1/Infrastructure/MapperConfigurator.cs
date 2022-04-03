using AutoMapper;
using LibraryBLL.Dto;
using LibraryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBLL.Infrastructure
{
    public class MapperConfigurator : Profile
    {
        //public MapperConfigurator()
        //{
        //    var configuration = new MapperConfiguration(configExpration=> 
        //    {
        //        configExpration.CreateMap<Author, AuthorDto>()
        //            .ForMember(destination => destination.FullName,
        //            option => option.MapFrom(source => $"{source.FirstName}{source.LastName}"))
        //            .ForMember(destination => destination.Id,
        //            option => option.MapFrom(source => source.Id))
        //            .ForMember(destinationMember => destinationMember.dateOfBirst,
        //            option => option.MapFrom(source => source.dateOfBith))
        //            .ReverseMap();
        //           // .ForAllOtherMembers(s => s.Ignore());
        //    });
        //}
        public MapperConfigurator()
        {
            var configuration = new MapperConfiguration(configExpression => 
            {

                configExpression.CreateMap<Author, AuthorDto>()
                    .ForMember(destination => destination.FullName
                    , option => option.MapFrom(course => $"{course.FirstName} +{ course.LastName}"))
                    .ForMember(destination => destination.Id, option => option.MapFrom(coutse => coutse.Id))
                    .ForMember(destination=>destination.dateOfBirst,option=>option.MapFrom(course=>course.dateOfBith))
                    .ReverseMap();

               // configExpression.CreateMap<AuthorDto, Author>().ReverseMap();
            });
        }
    }
}
