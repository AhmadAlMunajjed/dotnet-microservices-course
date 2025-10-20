namespace dotnet_microservices_course.Products;

public class ProductDto
{
    public string? Name { get; set; }
    public ProductType? Type { get; set; }
    public double? Price { get; set; }
    public double? Quantity { get; set; }
}
