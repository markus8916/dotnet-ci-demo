using Demo.Core;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSum() =>
        Assert.Equal(6, new Calculator().Add(2, 3));

    [Fact]
    public void Divide_ByZero_Throws() =>
        Assert.Throws<DivideByZeroException>(() => new Calculator().Divide(1, 0));
}