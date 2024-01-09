using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace EncodeCertificate
{
    class Program
    {
        static void Main(string[] args)
        {
            var cert = new X509Certificate2(args[0], args[1]);
            var data = Encoding.UTF8.GetBytes("2017-05-01T19:28:32.775Z");// DateTime.UtcNow.ToString("yyyy -MM-ddTHH:mm:ss.0Z"));
            ContentInfo info = new ContentInfo(data);
            SignedCms cms = new SignedCms(info, false);
            CmsSigner signer = new CmsSigner(cert);
            cms.ComputeSignature(signer, false);
            var signed = cms.Encode();
            var b64 = Convert.ToBase64String(signed);
            File.WriteAllText(args[2], b64);

            using (WebClient client = new WebClient())
            {
                client.Headers["tyl-efm-api"] = b64;
                client.DownloadFile(args[3], args[4]);
            }
        }
    }
}
