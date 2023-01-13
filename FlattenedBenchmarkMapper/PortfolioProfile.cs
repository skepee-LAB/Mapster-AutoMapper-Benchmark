﻿using AutoMapper;
using FlattenedBenchmarkMapper.Domains;
using FlattenedBenchmarkMapper.Dto;

namespace FlattenedBenchmarkMapper
{
    public class PortfolioProfile: Profile
    {
        public PortfolioProfile()
        {
            CreateMap<PortfolioSmall, DtoPortfolioSmallWithAdapter>()
                .ForMember(dest => dest.DtoId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.DtoCode, opt => opt.MapFrom(src => src.Code))
                .ForMember(dest => dest.DtoName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DtoType, opt => opt.MapFrom(src => src.Type))
                .ForMember(dest => dest.DtoStatus, opt => opt.MapFrom(src => src.Status));
        }
    }
}
