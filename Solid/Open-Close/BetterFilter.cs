public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> spec)
    {
        return items.Where(spec.IsSatisfied);
    }
}