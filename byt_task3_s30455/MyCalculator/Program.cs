using MyCalculator;

public class Program
{
    public static void Main() {
        Console.WriteLine("Addition:");
        Calculator addCalculator = new Calculator(10, 5, "+");
        Console.WriteLine(addCalculator);
        
        Console.WriteLine("Subtraction:");
        Calculator subCalculator = new Calculator(10, 5, "-");
        Console.WriteLine(subCalculator);
        
        Console.WriteLine("Multiplication:");
        Calculator mulCalculator = new Calculator(10, 5, "*");
        Console.WriteLine(mulCalculator);
        
        Console.WriteLine("Division:");
        Calculator divCalculator = new Calculator(10, 5, "/");
        Console.WriteLine(divCalculator);
        
        Console.WriteLine("Division by zero:");
        Calculator divByZero = new Calculator(10, 0, "/");
        Console.WriteLine(divByZero);
        
        Console.WriteLine("Negative numbers:");
        Calculator negativeCalc = new Calculator(-15, 3, "+");
        Console.WriteLine(negativeCalc);
        
        Console.WriteLine("Decimal numbers:");
        Calculator decimalCalc = new Calculator(7.5, 2.5, "*");
        Console.WriteLine(decimalCalc);

        Console.WriteLine("Large numbers:");
        Calculator largeCalc = new Calculator(1000000, 500000, "-");
        Console.WriteLine(largeCalc);
    }
}