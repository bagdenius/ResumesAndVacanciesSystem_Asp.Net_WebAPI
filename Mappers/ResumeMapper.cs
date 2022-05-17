﻿using AutoMapper;
using Domain;
using Entities;

namespace Mappers
{
    public class ResumeMapper : Profile
    {
        public ResumeMapper()
        {
            CreateMap<Resume, ResumeEntity>().ReverseMap();
        }
    }
}
