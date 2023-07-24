using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

[Table("Categories")]
public class Category: EntityBase
{
    [Required]
    public string Name { get; set; } =string.Empty;
    public int? ParentId { get; set; }
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public virtual ICollection<Product>? Products { set; get; }
}