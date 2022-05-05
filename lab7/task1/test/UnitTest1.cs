using Xunit;
using set;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Set s1 = new Set("abc");
        Set s2 = new Set("def");
        Set s3 = s1 + s2;
        Assert.Equal("abcdef", s3.ToString());
    }

    [Fact]
    public void Test2()
    {
        Set s1 = new Set("abc");
        Set s2 = new Set("cef");
        Set s3 = s1 + s2;
        Assert.Equal("abcef", s3.ToString());
    }

    [Fact]
    public void Test3()
    {
        Set s1 = new Set("abc");
        Set s2 = new Set("bcdef");
        Set s3 = s1 - s2;
        Assert.Equal("a", s3.ToString());
    }

    [Fact]
    public void Test6()
    {
        Set s1 = new Set("abc");
        Set s2 = new Set("ef");
        Set s3 = s1 - s2;
        Assert.Equal("abc", s3.ToString());
    }

    [Fact]
    public void Test4()
    {
        Set s1 = new Set("abcdef");
        Set s2 = new Set("bcdqwe");
        Set s3 = s2 * s1;
        Assert.Equal("bcde", s3.ToString());
    }

    [Fact]
    public void Test5()
    {
        Set s1 = new Set("abcdef");
        Set s2 = new Set("bcdqwe");
        Assert.True(s1 != s2);
    }

    [Fact]
    public void Test7()
    {
        Set s1 = new Set("abcdef");
        Set s2 = new Set("bcdef");
        Assert.False(s1 == s2);
    }

    [Fact]
    public void Test8()
    {
        Set s1 = new Set("abcdef");
        string str = "abcdef";
        Assert.True(s1.ToString() == str);
    }

    

}