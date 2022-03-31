using Xunit;
using dateservice;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string dateStringTest = "31.03.2022";
        int day = 31, month = 3, year = 2022;
        DateService date = new DateService();
        Assert.Equal("четверг", date.GetDay(dateStringTest));
        Assert.Equal(0, date.GetDaySpan(day, month, year));
    }

    [Fact]
    public void Test2()
    {
        string dateStringTest = "19.08.1967";
        int day = 19, month = 8, year = 1967;
        DateService date = new DateService();
        Assert.Equal("суббота", date.GetDay(dateStringTest));
        Assert.Equal(19948, date.GetDaySpan(day, month, year));
    }

    [Fact]
    public void Test3()
    {
        string dateStringTest = "01.12.2345";
        int day = 01, month = 12, year = 2345;
        DateService date = new DateService();
        Assert.Equal("суббота", date.GetDay(dateStringTest));
        Assert.Equal(118218, date.GetDaySpan(day, month, year));
    }
}