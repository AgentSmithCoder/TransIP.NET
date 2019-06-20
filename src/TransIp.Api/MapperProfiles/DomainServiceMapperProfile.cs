using AutoMapper;
using TransIp.Api.Dto.Domain;

namespace TransIp.Api
{
    public class DomainServiceMapperProfile : Profile
    {
        public DomainServiceMapperProfile()
        {
            CreateMap<DnsEntry, Remote.DnsEntry>();
            CreateMap<Remote.DnsEntry, DnsEntry>();

            CreateMap<Remote.Domain, Domain>()
                .ForMember(x => x.IsLocked, opt => opt.ResolveUsing(x => x.isLockedSpecified ? x.isLocked : (bool?)null));
            CreateMap<Domain, Remote.Domain>()
                .ForMember(x => x.isLocked, opt => opt.ResolveUsing(x => x.IsLocked.GetValueOrDefault(false)))
                .ForMember(x => x.isLockedSpecified, opt => opt.ResolveUsing(x => x.IsLocked.HasValue));

            CreateMap<Remote.DomainAction, DomainAction>();
            CreateMap<DomainAction, Remote.DomainAction>();

            CreateMap<Remote.DomainBranding, DomainBranding>();
            CreateMap<DomainBranding, Remote.DomainBranding>();

            CreateMap<Remote.DomainCheckResult, DomainCheckResult>();

            CreateMap<Remote.Nameserver, Nameserver>();
            CreateMap<Nameserver, Remote.Nameserver>();

            CreateMap<Remote.Tld, Tld>()
                .ForMember(x => x.CapabilityList, opt => opt.MapFrom(x => x.capabilities))
                .ForMember(x => x.Capabilities, opt => opt.Ignore());
            CreateMap<Tld, Remote.Tld>()
                .ForMember(x => x.capabilities, opt => opt.MapFrom(x => x.CapabilityList));

            CreateMap<Remote.WhoisContact, WhoisContact>()
                .ForMember(x => x.CompanyNumber, opt => opt.MapFrom(x => x.companyKvk));
            CreateMap<WhoisContact, Remote.WhoisContact>()
                .ForMember(x => x.companyKvk, opt => opt.MapFrom(x => x.CompanyNumber));
        }
    }
}