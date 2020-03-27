using AutoMapper;
using HelpMyStreet.Core.Dto;
using HelpMyStreet.Repo.EntityFramework.Entities;
//using HelpMyStreet.Repo.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelpMyStreet.Mappers
{
    public class PostCodeProfile : Profile
    {
        public PostCodeProfile()
        {
            CreateMap<PostCode, PostCodeDTO>()
                .ForMember(dest => dest.AddressDetails, opt => opt.Ignore());
            CreateMap<PostCodeDTO, PostCode>()
                .ForMember(dest => dest.AddressDetails, opt => opt.Ignore());
        }
    }
}
