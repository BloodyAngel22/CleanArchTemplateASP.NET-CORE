namespace TestClean.Core.Models
{
    public class Product
    {
		public Guid Id { get; set; } = Guid.NewGuid();
		public required string Name { get; set; }
		public required decimal Price { get; set; }
    }

    public class ProductDTO
    {
		public required string Name { get; set; }
		public required decimal Price { get; set; }
    }
}