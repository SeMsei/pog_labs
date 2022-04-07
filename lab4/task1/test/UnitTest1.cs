using Xunit;
using hostel;
using System;

namespace test;

public class UnitTest1
{
    Hostel hostel = Hostel.GetInstance("Proga", 10000, 1, 1000000);

    [Fact]
    public void Test_build()
    {
        Assert.True(hostel.getName()=="Proga" && hostel.getNumberOfRooms()==10000  && hostel.getNumberOfOccupiedRooms()==1  && hostel.getCost()==1000000);
    }

    [Fact]
    public void Test_IncCost()
    {
        hostel.IncCost(100);

        Assert.Equal(1000100, hostel.getCost());
    }

    [Fact]
    public void Test_DecCost()
    {
        Hostel hostel = Hostel.GetInstance("Proga", 10000, 1, 1000000);
        hostel.DecCost(100);

        Assert.True(hostel.getCost()==1000000);
    }

    [Fact]
    public void Test_getName()
    {
        Hostel hostel = Hostel.GetInstance("Proga123", 10000, 1, 1000000);
        Assert.True(hostel.getName()=="Proga");
    }

    [Fact]
    public void Test_getNumberOfRooms()
    {
        Hostel hostel = Hostel.GetInstance("Proga", 10123, 1, 1000000);
        Assert.True(hostel.getNumberOfRooms()==10000);
    }

    [Fact]
    public void Test_getNumberOfOccupiedRooms()
    {
        Hostel hostel = Hostel.GetInstance("Proga", 10000, 123, 1000000);
        Assert.True(hostel.getNumberOfOccupiedRooms()==1);
    }

    public void Test_New_Build()
    {
        Hostel hostel = Hostel.GetInstance("Proga123", 10123, 123, 1000123);
        Assert.True(hostel.getName()=="Proga" && hostel.getNumberOfRooms()==10000 && hostel.getNumberOfOccupiedRooms()==1 && hostel.getCost()==1000000);
    }
}