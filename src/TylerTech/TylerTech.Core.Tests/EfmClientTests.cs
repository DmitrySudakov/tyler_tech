using FluentAssertions;
using Microsoft.Extensions.Options;
using TylerTech.Core.Integrations.EfmClient;

namespace TylerTech.Core.Tests;

[TestFixture]
[Ignore("Integration tests.")]
public class EfmClientTests
{
    private const string BASE_URL = "https://maryland-stage.tylertech.cloud";
    private const string CERTIFICATE_FILE_PATH = "AutoAdmin.pfx";
    private const string CERTIFICATE_FILE_PASSWORD = "";
    private const string USER_EMAIL = "";
    private const string USER_PASSWORD = "";

    private IEfmClient _client;

    [SetUp]
    public void TestSetUp()
    {
        var settings = new EfmClientSettings
        {
            BaseUrl = BASE_URL,
            CertificateFilePath = CERTIFICATE_FILE_PATH,
            CertificateFilePassword = CERTIFICATE_FILE_PASSWORD
        };
        _client = new EfmClient(Options.Create(settings));
    }

    [Test]
    public async Task AuthenticateAsync_ExistingUser_ReturnsAuthenticatedUser()
    {
        var user = await _client.AuthenticateAsync(USER_EMAIL, USER_PASSWORD);
        user.Should().NotBeNull();
    }
}
