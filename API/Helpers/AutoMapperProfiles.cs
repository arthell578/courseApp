using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using AutoMapper;
using AutoMapper.Execution;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        protected AutoMapperProfiles()
        {
            CreateMap<User, MemberDTO>()
                .ForMember(m => m.PhotoUrl, opt=>opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url));
            CreateMap<Photo, PhotoDTO>();
        }
    }
}