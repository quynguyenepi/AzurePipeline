using ECM.Repo.Domain.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECM.Repo.Domain;

[Table("Products")]
public class Product:EntityBase
{
    [StringLength(255)]
    [Required]
    public string ProductName { get; set; }=string.Empty;
    [Required]
    [StringLength(255)]
    public string ProductNumber { get; set; } = string.Empty;
    public Guid CategoryId { get; set; }
    public string Image { get; set; } = string.Empty;

    [StringLength(255)]
    public string Unit { get; set; } = string.Empty;
    [Required]
    [DefaultValue(0)]
    public decimal Price { get; set; }
    public decimal? PromotionPrice { get; set; }
    public bool? HomeFlag { get; set; }
    public bool? SaleFlag { get; set; }
    public int? ViewCount { get; set; }
    public ProductStatus Status { set; get; }
    [ForeignKey("CategoryId")]
    public virtual Category Category { set; get; } = new();
    public virtual ICollection<ProductImage>? ProductImages { set; get; }
    public virtual ICollection<ProductTag>? ProductTags { set; get; }
    public virtual ICollection<ProductSize>? ProductSizes { set; get; }
    public virtual ICollection<ProductColor>? ProductColors { set; get; }
    public virtual ICollection<ProductOrigin>? ProductOrigins { set; get; }
}