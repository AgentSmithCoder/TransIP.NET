using System;
using AutoMapper;
using TransIp.Api.Dto.Vps;
using OperatingSystem = TransIp.Api.Dto.Vps.OperatingSystem;

namespace TransIp.Api
{
    public class VpsServiceMapperProfile : Profile
    {
        public VpsServiceMapperProfile()
        {
            CreateMap<string, DateTime>().ConvertUsing(new DateTimeTypeConverter());

            CreateMap<Remote.Vps, Vps>()
                .ForMember(t => t.IsLocked, o => o.Ignore());
            CreateMap<Remote.AvailabilityZone, AvailabilityZone>();
            //CreateMap<Remote.OperatingSystem, Dto.OperatingSystem>();

            CreateMap<Remote.VpsBackup, Backup>()
                .ForMember(t => t.Created, opt => opt.MapFrom(src => DateTime.Parse(src.dateTimeCreate)))
                ;


            CreateMap<Remote.Snapshot, Snapshot>()
                .ForMember(t => t.Created, opt => opt.MapFrom(src => DateTime.Parse(src.dateTimeCreate)))
                ;

            CreateMap<Remote.OperatingSystem, OperatingSystem>()
                .ForMember(t => t.Created, opt => opt.Ignore());

            CreateMap<Remote.Product, Dto.Vps.Product>();
        }
    }
}