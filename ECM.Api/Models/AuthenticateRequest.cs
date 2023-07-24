using ECM.Repo.Domain;
using System.ComponentModel.DataAnnotations;

namespace ECM.Api.Models
{
    public class AuthenticateRequest
    {
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
