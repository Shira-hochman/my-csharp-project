namespace Dto_Common_Enteties
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public int CategoryId { get; set; }
        public int Age { get; set; }

        public int CompanyId { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public string? Image { get; set; }

        public DateTime? LastUpdated { get; set; }
        public string? CategoryName { get; set; }

    
    }
}
