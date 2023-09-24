namespace models;

public class Circle : Shape
{
    private double Radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public override double Square()
    {
        return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
    }
}