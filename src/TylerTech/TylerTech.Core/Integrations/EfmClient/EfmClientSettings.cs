using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerTech.Core.Integrations.EfmClient;

public class EfmClientSettings
{
    public string BaseUrl { get; set; }
    public string CertificateFilePath { get; set; }
    public string CertificateFilePassword { get; set; }
}
