using AutoMapper;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using TylerTech.Core.Integrations.EfmClient.Mapping;
using TylerTech.Core.Integrations.EfmClient.Messages;

namespace TylerTech.Core.Integrations.EfmClient;

public class EfmClient : IEfmClient
{
    private readonly IMapper _mapper;
    private readonly EfmClientSettings _settings;

    public EfmClient(IOptions<EfmClientSettings> settings)
    {
        var configuration = new MapperConfiguration(x =>
        {
            x.AddProfile(new AutoMapperProfile());
        });
        _mapper = configuration.CreateMapper();

        _settings = settings.Value;
    }

    public async Task<AuthenticatedUser> AuthenticateAsync(string email, string password)
    {
        using (var client = CreateUserServiceClient())
        {
            var originRequest = new Origin.AuthenticateRequestType
            {
                Email = email,
                Password = password
            };
            var originResponse = await client.AuthenticateUserAsync(originRequest);

            var user = _mapper.Map<AuthenticatedUser>(originResponse);
            return user;
        }
    }

    private Origin.EfmUserServiceClient CreateUserServiceClient()
    {
        var binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
        binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.Certificate;
        binding.MessageEncoding = WSMessageEncoding.Mtom;

        var requestUri = new Uri(new Uri(_settings.BaseUrl), "EFM/EFMUserService.svc").ToString();
        var endpointAddress = new EndpointAddress(requestUri);

        var client = new Origin.EfmUserServiceClient(binding, endpointAddress);
        client.ClientCredentials.ClientCertificate.Certificate = GetCertificate();

        return client;
    }

    private X509Certificate2 GetCertificate()
    {
        return new X509Certificate2(_settings.CertificateFilePath, _settings.CertificateFilePassword);
    }
}
