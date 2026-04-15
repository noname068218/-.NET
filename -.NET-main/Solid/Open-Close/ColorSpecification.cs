public class ColorSpecification : Specification<Product>
{
    private readonly Color color;
    public ColorSpecification(Color color)
    {
        this.color = color;
    }

    public override bool IsSatisfied(Product item)
    {
        return item.Color == color;
    }
}