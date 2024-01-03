using ExampleEFMClient.EFM;
using System;

namespace ExampleEFMClient
{
  public class Program
  {
    public static void Main(string[] args)
    {
      // Load a certificate from a file, specifying the password for the private key.
      EFMClient efm = new EFMClient("path to .pfx file", "password");

      // Alternatively, you can load a certificate from a certificate store
      //EFMClient client = new EFMClient("subject name");

      // Build a request
      AuthenticateRequestType request = CreateAuthenticationRequest("email@test.com", "password");

      // Call the EFM web service
      AuthenticateResponseType response = efm.AuthenticateUser(request);

      // Handle the response
      HandleAuthenticationResponse(request, response);
    }

    private static AuthenticateRequestType CreateAuthenticationRequest(string email, string password)
    {
      return new AuthenticateRequestType()
      {
        Email = email,
        Password = password
      };
    }

    private static void HandleAuthenticationResponse(AuthenticateRequestType request, AuthenticateResponseType response)
    {
      if (response.Error != null && response.Error.ErrorCode != "0")
      {
        Console.WriteLine("{0} was not signed in because {1}", request.Email, response.Error.ErrorText);
      }
      else
      {
        Console.WriteLine("{0} {1} is now signed in", response.FirstName, response.LastName);
      }
    }
  }
}
