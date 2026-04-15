public class ProductFilter
{
    public IEnumerable<Product> Filter(IEnumerable<Product> products, Color color)
    {
        return products.Where(p => p.Color == color);
    }
}