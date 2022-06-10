using App.DataProvider.Models;
using App.Services.ViewModels;
using AutoMapper;
using System;

namespace App.Services
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            AllowNullDestinationValues = true;
            //Source -> Destination
            CreateMap<Vehicle, VehicleDto>()
                .ForMember(dto => dto.Type, opt => opt.MapFrom(src => src.Type))
                .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.Name));

            //CreateMap<UserRoles, RoleDto>()
            //   .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.RoleId))
            //   .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.RoleName));

            //CreateMap<UserGroup, GroupDto>()
            //  .ForMember(dto => dto.Id, opt => opt.MapFrom(src => src.Id))
            //  .ForMember(dto => dto.Name, opt => opt.MapFrom(src => src.GroupName));

            //CreateMap<User, LoginModel>()
            //    .ForMember(dto => dto.UserName, opt => opt.MapFrom(src => src.Email));

        }

    }
}
