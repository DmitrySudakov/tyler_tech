using TylerTech.Core.Integrations.EfmClient.Messages;

namespace TylerTech.Core.Integrations.EfmClient;

public interface IEfmClient
{
    Task<AuthenticateResponse> AuthenticateAsync(AuthenticateRequest request);
}
