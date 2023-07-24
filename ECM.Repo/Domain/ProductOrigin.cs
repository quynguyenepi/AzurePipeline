using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

[Table("ProductOrigins")]
public class ProductOrigin:EntityBase
{
    public Guid ProductId { get; set; }
    public Guid OriginId { set; get; }

    [ForeignKey("ProductId")]
    public virtual Product Product { set; get; } = new();

    [ForeignKey("OriginId")]
    public virtual Origin Origin { set; get; } = new();
}