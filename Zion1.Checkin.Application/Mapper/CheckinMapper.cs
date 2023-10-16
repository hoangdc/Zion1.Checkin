using AutoMapper;
using Zion1.Checkin.Application.Commands.CreateVisitor;
using Zion1.Checkin.Domain.Entities;
using Zion1.Common.Application.Mapper;

namespace Zion1.Checkin.Application.Mapper
{
    public class CheckinMappingProfile : Profile
    {
        public CheckinMappingProfile()
        {
            CreateMap<Visitor, CreateVisitorRequest>().ReverseMap();
        }
    }

    public class CheckinMapper : CommonMapper<CheckinMappingProfile>
    {

    }
}
