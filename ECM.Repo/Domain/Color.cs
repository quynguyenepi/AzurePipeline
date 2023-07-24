using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

[Table("Colors")]
public class Color: EntityBase
{
    [Required]
    [StringLength(250)]
    public string Name { get; set; } = string.Empty;
    [Required]
    [StringLength(250)]
    public string Code { get; set; } = string.Empty;
}