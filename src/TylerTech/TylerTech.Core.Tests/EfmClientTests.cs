using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TylerTech.Core.Integrations.EfmClient;

namespace TylerTech.Core.Tests;

[TestFixture]
public class EfmClientTests
{
    private IEfmClient _client;

    [SetUp]
    public void TestSetUp()
    {
        var settings = new EfmClientSettings
        {
            BaseUrl = "",
            CertificateFilePath = "",
            CertificateFilePassword = ""
        };
        _client = new EfmClient(Options.Create(settings));
    }
}
