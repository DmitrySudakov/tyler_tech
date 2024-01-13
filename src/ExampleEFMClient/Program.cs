using ExampleEFMClient.EFM;
using System;

namespace ExampleEFMClient {

  public static class Consts {
    public static string PFX_PWD = "<REPLACE_ME>";
    public static string USER_EMAIL = "<REPLACE_ME>";
    public static string USER_PWD = "<REPLACE_ME>";
  }

  public class Program {
    public static void Main(string[] args) {
      // Load a certificate from a file, specifying the password for the private key.
      EFMClient efm = new EFMClient("certs/AutoAdmin.pfx", Consts.PFX_PWD);

      // Build a request
      AuthenticateRequestType request = new AuthenticateRequestType() {
        Email = Consts.USER_EMAIL,
        Password = Consts.USER_PWD,
      };

      // Call the EFM web service
      AuthenticateResponseType response = efm.AuthenticateUser(request);

      // Handle the response
      HandleAuthenticationResponse(request, response);
    }

    private static void HandleAuthenticationResponse(AuthenticateRequestType request, AuthenticateResponseType response) {
      if (response.Error != null && response.Error.ErrorCode != "0") {
        Console.WriteLine("{0} was not signed in because {1}", request.Email, response.Error.ErrorText);
      } else {
        Console.WriteLine("{0} {1} is now signed in", response.FirstName, response.LastName);
      }
    }
  }
}
