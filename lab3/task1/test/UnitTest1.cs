using Xunit;
using calculate;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Calculate calculator = new Calculate();
        int num = 13;
        num = calculator.change(num);
        Assert.Equal(16, num);
    }

    [Fact]

    public void Test2()
    {
        Calculate calculator = new Calculate();
        int num = 14;
        num = calculator.change(num);
        Assert.Equal(7, num);
    }
}