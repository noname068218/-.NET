public class Demo 
{
public static void UseIt(Rectangle r)
{
int width = r.Width;
r.Height = 10;
Console.WriteLine($"Expected area of {width}, got {r.Area()}");
}
}