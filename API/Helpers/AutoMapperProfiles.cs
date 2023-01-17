using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Extensions;
using AutoMapper;
using AutoMapper.Execution;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        protected AutoMapperProfiles()
        {
            CreateMap<User, MemberDTO>()
                .ForMember(m => m.PhotoUrl, opt=>opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(m => m.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDTO>();
        }
    }
}