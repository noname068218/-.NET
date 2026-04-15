public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area()
    {
        return Width * Height;
    }

    public override string ToString()
    {
        return $"Rectangle: Width = {Width}, Height = {Height}";
    }
}