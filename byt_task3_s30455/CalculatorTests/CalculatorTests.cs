using MyCalculator;

namespace CalculatorTests;

public class Tests {
    // Addition tests
    [Test]
    public void TestAdditionPositiveNumbers()
    {
        Calculator calc = new Calculator(10, 5, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(15));
    }

    [Test]
    public void TestAdditionNegativeNumbers()
    {
        Calculator calc = new Calculator(-10, -5, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(-15));
    }

    [Test]
    public void TestAdditionMixedNumbers()
    {
        Calculator calc = new Calculator(-10, 5, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestAdditionWithZero()
    {
        Calculator calc = new Calculator(10, 0, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(10));
    }

    [Test]
    public void TestAdditionDecimalNumbers()
    {
        Calculator calc = new Calculator(7.5, 2.3, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(9.8).Within(0.001));
    }

    [Test]
    public void TestAdditionLargeNumbers()
    {
        Calculator calc = new Calculator(1000000, 2000000, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(3000000));
    }

    [Test]
    public void TestAdditionVerySmallNumbers()
    {
        Calculator calc = new Calculator(0.0001, 0.0002, "+");
        Assert.That(calc.Calculate(), Is.EqualTo(0.0003).Within(0.00001));
    }
    
    // Substraction tests
    [Test]
    public void TestSubtractionPositiveNumbers()
    {
        Calculator calc = new Calculator(10, 5, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(5));
    }

    [Test]
    public void TestSubtractionNegativeNumbers()
    {
        Calculator calc = new Calculator(-10, -5, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestSubtractionResultInNegative()
    {
        Calculator calc = new Calculator(5, 10, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(-5));
    }

    [Test]
    public void TestSubtractionWithZero()
    {
        Calculator calc = new Calculator(10, 0, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(10));
    }

    [Test]
    public void TestSubtractionFromZero()
    {
        Calculator calc = new Calculator(0, 10, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(-10));
    }

    [Test]
    public void TestSubtractionDecimalNumbers()
    {
        Calculator calc = new Calculator(7.5, 2.3, "-");
        Assert.That(calc.Calculate(), Is.EqualTo(5.2).Within(0.001));
    }

    // Multiplication tests
    [Test]
    public void TestMultiplicationPositiveNumbers()
    {
        Calculator calc = new Calculator(10, 5, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(50));
    }

    [Test]
    public void TestMultiplicationNegativeNumbers()
    {
        Calculator calc = new Calculator(-10, -5, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(50));
    }

    [Test]
    public void TestMultiplicationMixedNumbers()
    {
        Calculator calc = new Calculator(-10, 5, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(-50));
    }

    [Test]
    public void TestMultiplicationByZero()
    {
        Calculator calc = new Calculator(10, 0, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(0));
    }

    [Test]
    public void TestMultiplicationByOne()
    {
        Calculator calc = new Calculator(10, 1, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(10));
    }

    [Test]
    public void TestMultiplicationDecimalNumbers()
    {
        Calculator calc = new Calculator(7.5, 2.0, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(15.0).Within(0.001));
    }

    [Test]
    public void TestMultiplicationLargeNumbers()
    {
        Calculator calc = new Calculator(1000, 2000, "*");
        Assert.That(calc.Calculate(), Is.EqualTo(2000000));
    }

    // Division tests
    [Test]
    public void TestDivisionPositiveNumbers()
    {
        Calculator calc = new Calculator(10, 5, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(2));
    }

    [Test]
    public void TestDivisionNegativeNumbers()
    {
        Calculator calc = new Calculator(-10, -5, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(2));
    }

    [Test]
    public void TestDivisionMixedNumbers()
    {
        Calculator calc = new Calculator(-10, 5, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(-2));
    }

    [Test]
    public void TestDivisionByZero()
    {
        Calculator calc = new Calculator(10, 0, "/");
        Assert.Throws<DivideByZeroException>(() => calc.Calculate());
    }

    [Test]
    public void TestDivisionByOne()
    {
        Calculator calc = new Calculator(10, 1, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(10));
    }

    [Test]
    public void TestDivisionResultInDecimal()
    {
        Calculator calc = new Calculator(10, 3, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(3.333).Within(0.001));
    }

    [Test]
    public void TestDivisionZeroByNumber()
    {
        Calculator calc = new Calculator(0, 10, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(0));
    }

    [Test]
    public void TestDivisionDecimalNumbers()
    {
        Calculator calc = new Calculator(7.5, 2.5, "/");
        Assert.That(calc.Calculate(), Is.EqualTo(3.0).Within(0.001));
    }
}