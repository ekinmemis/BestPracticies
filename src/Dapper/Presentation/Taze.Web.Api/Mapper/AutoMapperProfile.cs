using AutoMapper;
using Taze.Core.Domain.Topics;
using Taze.Web.Api.Model.Topics;

namespace Taze.Web.Api.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Topic, TopicModel>();
            CreateMap<TopicModel, Topic>().IgnoreAllVirtual();
        }
    }
}
