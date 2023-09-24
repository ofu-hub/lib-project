namespace models;

public class Triangle : Shape
{
    private double Ab { get; set; }
    private double Bc { get; set; }
    private double Ac { get; set; }

    public Triangle(string name, double ab, double bc, double ac) : base(name)
    {
        if (ab < 0 || bc < 0 || ac < 0) 
            throw new ArgumentException($"Error: Side can not be less than 0\nCheck your input values");
        if (ab > (bc + ac) || bc > (ab + ac) || ac > (ab + bc)) 
            throw new ArgumentException($"Error: Your side greater than summary of two another sides\nCheck your input values");
        Ab = ab;
        Bc = bc;
        Ac = ac;
    }

    public override double Square()
    {
        var p = (Ab + Bc + Ac) / 2;
        var result = Math.Round(Math.Sqrt(p * (p - Ab) * (p - Bc) * (p - Ac)), 1);
        return result;
    }

    public bool IsRectangular()
    {
        return (Ab == Math.Sqrt(Math.Pow(Bc, 2) + Math.Pow(Ac, 2)) 
                || Bc == Math.Sqrt(Math.Pow(Ab, 2) + Math.Pow(Ac, 2)) 
                || Ac == Math.Sqrt(Math.Pow(Ab, 2) + Math.Pow(Bc, 2)));
    }
}