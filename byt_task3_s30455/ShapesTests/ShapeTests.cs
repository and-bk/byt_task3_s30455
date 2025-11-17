using byt_task3_s30455;

namespace ShapesTests;

public class ShapeTests {
    //Sphere tests
    private readonly IShape sphere = new Sphere(5);

    [Test]
    public void TestSphereCalculateArea()
    {
        Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
    }

    [Test]
    public void TestSphereCalculateVolume()
    {
        Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
    }

    [Test]
    public void TestSphereWithRadiusOne()
    {
        IShape smallSphere = new Sphere(1);
        Assert.That(smallSphere.CalculateArea(), Is.EqualTo(4 * Math.PI).Within(0.001));
        Assert.That(smallSphere.CalculateVolume(), Is.EqualTo(4.0 / 3.0 * Math.PI).Within(0.001));
    }

    [Test]
    public void TestSphereWithZeroRadius()
    {
        IShape zeroSphere = new Sphere(0);
        Assert.That(zeroSphere.CalculateArea(), Is.EqualTo(0));
        Assert.That(zeroSphere.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestSphereWithLargeRadius()
    {
        IShape largeSphere = new Sphere(100);
        Assert.That(largeSphere.CalculateArea(), Is.EqualTo(125663.706).Within(0.001));
        Assert.That(largeSphere.CalculateVolume(), Is.EqualTo(4188790.205).Within(0.001));
    }

    [Test]
    public void TestSphereWithDecimalRadius()
    {
        IShape decimalSphere = new Sphere(2.5);
        Assert.That(decimalSphere.CalculateArea(), Is.EqualTo(78.539).Within(0.001));
        Assert.That(decimalSphere.CalculateVolume(), Is.EqualTo(65.449).Within(0.001));
    }
    
    //Cylinder tests
    [Test]
    public void TestCylinderCalculateArea()
    {
        IShape cylinder = new Cylinder(3, 7);
        Assert.That(cylinder.CalculateArea(), Is.EqualTo(188.495).Within(0.001));
    }

    [Test]
    public void TestCylinderCalculateVolume()
    {
        IShape cylinder = new Cylinder(3, 7);
        Assert.That(cylinder.CalculateVolume(), Is.EqualTo(197.920).Within(0.001));
    }

    [Test]
    public void TestCylinderWithUnitDimensions()
    {
        IShape unitCylinder = new Cylinder(1, 1);
        Assert.That(unitCylinder.CalculateArea(), Is.EqualTo(4 * Math.PI).Within(0.001));
        Assert.That(unitCylinder.CalculateVolume(), Is.EqualTo(Math.PI).Within(0.001));
    }

    [Test]
    public void TestCylinderWithZeroHeight()
    {
        IShape flatCylinder = new Cylinder(5, 0);
        Assert.That(flatCylinder.CalculateArea(), Is.EqualTo(2 * Math.PI * 5 * 5).Within(0.001));
        Assert.That(flatCylinder.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestCylinderWithZeroRadius()
    {
        IShape thinCylinder = new Cylinder(0, 10);
        Assert.That(thinCylinder.CalculateArea(), Is.EqualTo(0));
        Assert.That(thinCylinder.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestCylinderWithLargeDimensions()
    {
        IShape largeCylinder = new Cylinder(10, 20);
        Assert.That(largeCylinder.CalculateArea(), Is.EqualTo(1884.955).Within(0.001));
        Assert.That(largeCylinder.CalculateVolume(), Is.EqualTo(6283.185).Within(0.001));
    }

    [Test]
    public void TestCylinderWithDecimalDimensions()
    {
        IShape decimalCylinder = new Cylinder(1.5, 4.5);
        Assert.That(decimalCylinder.CalculateArea(), Is.EqualTo(56.548).Within(0.001));
        Assert.That(decimalCylinder.CalculateVolume(), Is.EqualTo(31.808).Within(0.001));
    }
    
    //Rectangle tests
    [Test]
    public void TestRectangleCalculateArea()
    {
        IShape rectangle = new Rectangle(4, 8);
        Assert.That(rectangle.CalculateArea(), Is.EqualTo(32));
    }

    [Test]
    public void TestRectangleCalculateVolume()
    {
        IShape rectangle = new Rectangle(4, 8);
        Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestRectangleSquare()
    {
        IShape square = new Rectangle(5, 5);
        Assert.That(square.CalculateArea(), Is.EqualTo(25));
        Assert.That(square.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestRectangleWithUnitDimensions()
    {
        IShape unitRectangle = new Rectangle(1, 1);
        Assert.That(unitRectangle.CalculateArea(), Is.EqualTo(1));
        Assert.That(unitRectangle.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestRectangleWithZeroLength()
    {
        IShape zeroLengthRect = new Rectangle(0, 5);
        Assert.That(zeroLengthRect.CalculateArea(), Is.EqualTo(0));
        Assert.That(zeroLengthRect.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestRectangleWithZeroWidth()
    {
        IShape zeroWidthRect = new Rectangle(5, 0);
        Assert.That(zeroWidthRect.CalculateArea(), Is.EqualTo(0));
        Assert.That(zeroWidthRect.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestRectangleWithDecimalDimensions()
    {
        IShape decimalRect = new Rectangle(3.5, 2.5);
        Assert.That(decimalRect.CalculateArea(), Is.EqualTo(8.75));
        Assert.That(decimalRect.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestRectangleWithLargeDimensions()
    {
        IShape largeRect = new Rectangle(100, 200);
        Assert.That(largeRect.CalculateArea(), Is.EqualTo(20000));
        Assert.That(largeRect.CalculateVolume(), Is.EqualTo(0));
    }
    
    //Cube tests
    [Test]
    public void TestCubeCalculateArea()
    {
        IShape cube = new Cube(4);
        Assert.That(cube.CalculateArea(), Is.EqualTo(96));
    }

    [Test]
    public void TestCubeCalculateVolume()
    {
        IShape cube = new Cube(4);
        Assert.That(cube.CalculateVolume(), Is.EqualTo(64));
    }

    [Test]
    public void TestCubeWithUnitSide()
    {
        IShape unitCube = new Cube(1);
        Assert.That(unitCube.CalculateArea(), Is.EqualTo(6));
        Assert.That(unitCube.CalculateVolume(), Is.EqualTo(1));
    }

    [Test]
    public void TestCubeWithZeroSide()
    {
        IShape zeroCube = new Cube(0);
        Assert.That(zeroCube.CalculateArea(), Is.EqualTo(0));
        Assert.That(zeroCube.CalculateVolume(), Is.EqualTo(0));
    }

    [Test]
    public void TestCubeWithDecimalSide()
    {
        IShape decimalCube = new Cube(2.5);
        Assert.That(decimalCube.CalculateArea(), Is.EqualTo(37.5));
        Assert.That(decimalCube.CalculateVolume(), Is.EqualTo(15.625));
    }

    [Test]
    public void TestCubeWithLargeSide()
    {
        IShape largeCube = new Cube(10);
        Assert.That(largeCube.CalculateArea(), Is.EqualTo(600));
        Assert.That(largeCube.CalculateVolume(), Is.EqualTo(1000));
    }
}