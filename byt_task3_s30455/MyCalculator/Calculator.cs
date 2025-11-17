namespace MyCalculator;

public class Calculator {
    public double A { get; }
    public double B { get; }
    public string Operation { get; }

    public Calculator(double a, double b, string operation)
    {
        A = a;
        B = b;
        Operation = operation;
    }

    public double Calculate()
    {
        return Operation switch
        {
            "+" => A + B,
            "-" => A - B,
            "*" => A * B,
            "/" => DivideWithValidation()
        };
    }

    private double DivideWithValidation()
    {
        if (B == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return A / B;
    }

    public override string ToString()
    {
        try
        {
            double result = Calculate();
            return $"{A} {Operation} {B} = {result}";
        }
        catch (Exception ex)
        {
            return $"{A} {Operation} {B} = Error: {ex.Message}";
        }
    }
}