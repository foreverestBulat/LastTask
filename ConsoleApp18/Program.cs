double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());

if (y > 0)
{
    if ((x >= 0) & (x <= 1) & (y <= 1))
    {
        Console.WriteLine("Exists");
    }
    else if ((Math.Abs(x) + Math.Abs(y) <= 1) & (x >= -1))
    {
        Console.WriteLine("Exists");
    }
    else
    {
        Console.WriteLine("Doesn't exists");
    }
}
else if (y <= 0)
{
    if ((x >= -1) & (y * y + x * x <= 1) & (x <= 0))
    {
        Console.WriteLine("Exists");
    }
    else
    {
        Console.WriteLine("Doesn't exists");
    }
}
else
{
    Console.WriteLine("Doesn't exists");
}