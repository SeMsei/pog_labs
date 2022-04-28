using Xunit;
using racing;
using yoga;


namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Yoga yoga = new Yoga(30, 10);
        Assert.Equal("In yoga only 1 person", yoga.GetNumberOfParticipant());
    }

    [Fact]
    public void Test2()
    {
        Yoga yoga = new Yoga(30, 10);
        Assert.Equal("Number of exercises: 10", yoga.GetNumOfExercise());
    }

    [Fact]
    public void Test3()
    {
        Yoga yoga = new Yoga(30, 10);
        Assert.Equal(30, yoga.GetTime());
    }

    [Fact]
    public void Test4()
    {
        Yoga yoga = new Yoga(30, 10);
        Assert.Equal("yoga", yoga.getName());
    }

    [Fact]
    public void Test5()
    {
        Racing racing = new Racing(30, 10, 10);
        Assert.Equal("Number of lap: 10", racing.GetNumOfLap());
    }

    [Fact]
    public void Test6()
    {
        Racing racing = new Racing(30, 10, 10);
        Assert.Equal("racing", racing.getName());
    }

    [Fact]
    public void Test7()
    {
        Racing racing = new Racing(30, 10, 10);
        Assert.Equal(30, racing.GetTime());
    }

    [Fact]
    public void Test8()
    {
        Racing racing = new Racing(30, 10, 10);
        Assert.Equal("Number of participants: 10", racing.GetNumberOfParticipant());
    }
}