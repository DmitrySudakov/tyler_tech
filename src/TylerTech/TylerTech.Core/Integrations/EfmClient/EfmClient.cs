using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerTech.Core.Integrations.EfmClient;

public class EfmClient : IEfmClient
{
    private readonly EfmClientSettings _settings;

    public EfmClient(IOptions<EfmClientSettings> settings)
	{
        _settings = settings.Value;
    }
}
