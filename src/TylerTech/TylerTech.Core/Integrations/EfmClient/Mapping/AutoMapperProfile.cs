using AutoMapper;
using TylerTech.Core.Integrations.EfmClient.Messages;

namespace TylerTech.Core.Integrations.EfmClient.Mapping;

internal class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Origin.AuthenticateResponseType, AuthenticatedUser>();
    }
}
