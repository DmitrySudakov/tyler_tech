using ExampleEFMClient.EFM;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;


namespace ExampleEFMClient {
  public class EFMClient {

    private X509Certificate2 MessageSigningCertificate { get; set; }

    public EFMClient(string pfxFilePath, string privateKeyPassword) {
      this.MessageSigningCertificate = new X509Certificate2(pfxFilePath, privateKeyPassword);

      // Uncomment this line to ignore server certificate errors
      // This is useful if running through a proxy (like Fiddler) to capture the message content
      ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
    }

    public AuthenticateResponseType AuthenticateUser(AuthenticateRequestType request) {
      EfmUserServiceClient userService = this.CreateUserService();
      userService.Open();
      AuthenticateResponseType response = userService.AuthenticateUser(request);
      userService.Close();
      return response;
    }

    protected EfmUserServiceClient CreateUserService() {
      // Create and configure the binding
      var binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential);
      binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.Certificate;
      binding.MessageEncoding = WSMessageEncoding.Mtom;
      

      // Define the endpoint address
      var endpointAddress = new EndpointAddress("https://maryland-stage.tylertech.cloud/EFM/EFMUserService.svc");

      // Create the client instance
      var client = new EfmUserServiceClient(binding, endpointAddress);

      // Set the client credentials (certificate)
      client.ClientCredentials.ClientCertificate.Certificate = this.MessageSigningCertificate;

      // set client loggers
      client.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());

      return client;
    }
  }
}
