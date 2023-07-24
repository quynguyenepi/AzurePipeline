﻿using ECM.Repo.Domain;

namespace ECM.Api.Models
{
    public class AuthenticateResponse
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string Token { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            user.Username = token;
            Token = token;
        }
    }
}
