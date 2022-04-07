using Xunit;
using System;
using dateservice;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string dateStringTest = "31.03.2022";
        int day = DateTime.Now.Day , month = DateTime.Now.Month, year = DateTime.Now.Year;
        DateTime day_w_test = new DateTime(2022, 03, 31);
        DateService date = new DateService();
        Assert.Equal(day_w_test.ToString("dddd"), date.GetDay(dateStringTest));
        DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        DateTime dt1 = new DateTime(2022, 03, 31);
        int dif = (int) Math.Abs((dt-dt1).TotalDays);
        Assert.Equal(dif, date.GetDaySpan(31, 03, 2022));
    }

    [Fact]
    public void Test2()
    {
        string dateStringTest = "19.08.1967";
        DateTime day_w_test = new DateTime(1967, 08, 19);
        DateService date = new DateService();
        Assert.Equal(day_w_test.ToString("dddd"), date.GetDay(dateStringTest));
        DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        DateTime dt1 = new DateTime(1967, 08, 19);
        int dif = (int) Math.Abs((dt-dt1).TotalDays);
        Assert.Equal(dif, date.GetDaySpan(19, 08, 1967));
    }

    [Fact]
    public void Test3()
    {
        string dateStringTest = "01.12.2345";
        int day = DateTime.Now.Day , month = DateTime.Now.Month, year = DateTime.Now.Year;
        DateTime day_w_test = new DateTime(2345, 12, 1);
        DateService date = new DateService();
        Assert.Equal(day_w_test.ToString("dddd"), date.GetDay(dateStringTest));
        DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        DateTime dt1 = new DateTime(2345, 12, 1);
        int dif = (int) Math.Abs((dt-dt1).TotalDays);
        Assert.Equal(dif, date.GetDaySpan(1, 12, 2345));
    }
}