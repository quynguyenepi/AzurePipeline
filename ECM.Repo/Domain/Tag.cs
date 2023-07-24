using System.ComponentModel.DataAnnotations;

namespace ECM.Repo.Domain;

public class Tag:EntityBase
{
    [MaxLength(50)]
    [Required]
    public string Name { get; set; } = string.Empty;
}