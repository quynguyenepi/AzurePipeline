using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

public class ProductSize:EntityBase
{
    public Guid ProductId { get; set; }
    public Guid SizeId { set; get; }

    [ForeignKey("ProductId")]
    public virtual Product Product { set; get; } = new();

    [ForeignKey("SizeId")]
    public virtual Size Size { set; get; }=new();
}