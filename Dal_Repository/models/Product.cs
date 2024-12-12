using System;
using System.Collections.Generic;

namespace Dal_Repository.models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public int CategoryId { get; set; }

    public int CompanyId { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public string? Image { get; set; }

    public int Age { get; set; }    
    public DateTime? LastUpdated { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Company Company { get; set; } = null!;

    public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; } = new List<PurchaseDetail>();
}
