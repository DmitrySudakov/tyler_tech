using TylerTech.Core.Integrations.EfmClient.Messages;

namespace TylerTech.Core.Integrations.EfmClient;

public interface IEfmClient
{
    Task<AuthenticatedUser> AuthenticateAsync(string email, string password);
}
