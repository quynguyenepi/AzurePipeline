using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

public class ProductTag:EntityBase
{
    public Guid ProductId { get; set; }
    public Guid TagId { set; get; }

    [ForeignKey("ProductId")]
    public virtual Product Product { set; get; } = new();

    [ForeignKey("TagId")]
    public virtual Tag Tag { set; get; } = new ();
}