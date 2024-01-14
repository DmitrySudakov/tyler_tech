﻿namespace TylerTech.Core.Integrations.EfmClient.Messages;

public class AuthenticateResponse
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PasswordHash { get; set; }
}
