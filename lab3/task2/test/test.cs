using Xunit;
using System;
using function;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double y;
        int opt;
        Funct funct = new Funct();
        y = funct.test_res(9);
        opt = funct.test_opt(-2);
        Assert.Equal(1, opt);
        Assert.Equal(8104.299374373548, y);
    }

    [Fact]
    public void Test2()
    {
        double y;
        int opt;
        Funct funct = new Funct();
        y = funct.test_res(1);
        opt = funct.test_opt(2);
        Assert.Equal(2, opt);
        Assert.Equal(2.718281828459045, y);
    }
}