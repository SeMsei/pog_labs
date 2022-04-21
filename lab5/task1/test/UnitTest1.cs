using Xunit;
using hostel;
using client;
using room;

namespace test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Hostel h = new Hostel(1,1);
        h.addRooms(RoomType.Single, 100, 1);
        h.registerClient("Ivanov", RoomType.Single);
        Assert.Equal(100, h.clientCost("Ivanov"));
    }

    [Fact]
    public void Test2()
    {
        Hostel h = new Hostel(2,2);
        h.addRooms(RoomType.Single, 100, 2);
        h.registerClient("Ivanov", RoomType.Single);
        Assert.Equal("1 Single 100\n", h.listOfFreeRoom());
    }

    [Fact]
    public void Test3()
    {
        Hostel h = new Hostel(1,1);
        h.addRooms(RoomType.Single, 100, 1);
        Assert.True(h.registerClient("Petrov", RoomType.Single));
    }

    [Fact]
    public void Test4()
    {
        Hostel h = new Hostel(1,1);
        h.addRooms(RoomType.Single, 100, 1);
        h.registerClient("Ivanov", RoomType.Single);
        Assert.False(h.registerClient("Petrov", RoomType.Single));
    }

    [Fact]
    public void Test5()
    {
        Hostel h = new Hostel(1,1);
        h.addRooms(RoomType.Single, 100, 1);
        Assert.Equal("0 Single 100\n", h.listOfFreeRoom());
    }

    [Fact]
    public void Test6()
    {
        Hostel h = new Hostel(2,2);
        h.addRooms(RoomType.Single, 100, 2);
        h.registerClient("Ivanov", RoomType.Single);
        Assert.False(h.registerClient("Ivanov", RoomType.Single));
    }

}