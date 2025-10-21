namespace catalog.Products;

public class CreateUpdateProductDto
{
    public string? Name { get; set; }
    public ProductType? Type { get; set; }
    public double? Price { get; set; }
    public double? Quantity { get; set; }
}
