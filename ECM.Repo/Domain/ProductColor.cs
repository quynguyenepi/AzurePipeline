using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

public class ProductColor:EntityBase
{
    public Guid ProductId { get; set; }
    public Guid ColorId { set; get; }

    [ForeignKey("ProductId")]
    public virtual Product Product { set; get; } = new();

    [ForeignKey("ColorId")]
    public virtual Color Color { set; get; } = new();
}