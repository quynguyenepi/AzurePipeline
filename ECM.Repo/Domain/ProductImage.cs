using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

[Table("ProductImages")]
public class ProductImage:EntityBase
{
    public Guid ProductId { get; set; }
    [StringLength(500)]
    public string Path { get; set; }= string.Empty;

    [StringLength(255)]
    public string Description { get; set; } = string.Empty;
    [ForeignKey("ProductId")]
    public virtual Product Product { get; set; } = new();
}