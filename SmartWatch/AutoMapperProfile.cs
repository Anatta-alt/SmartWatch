using AutoMapper;
using SmartWatch.DTOs;
using SmartWatch.DTOs.ColorWatch;
using SmartWatch.DTOs.DetailWatch;
using SmartWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWatch
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Role, RoleDto>()
                .ForMember(x => x.RoleName, x => x.MapFrom(x => x.Name));
            CreateMap<RoleDtoAdd, Role>()
                .ForMember(x => x.Name, x => x.MapFrom(x => x.RoleName)); ;
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<BrandWatch, BrandWatchDTO_ToReturn>();
            CreateMap<DetailWatch, DetailWatchDTO_ToReturn>();
            CreateMap<ColorWatch, ColorWatchDTO_ToReturn>();


        }
    }
}