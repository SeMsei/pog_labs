// See https://aka.ms/new-console-template for more information
using System;
using hostel;
using room;

Console.WriteLine("Hello, World!");

Hostel h = new Hostel(10, 10);

h.addRooms(RoomType.Single, 100, 2);
h.addRooms(RoomType.Double, 200, 2);
h.addRooms(RoomType.Triple, 300, 2);
h.addRooms(RoomType.Quad, 400, 2);
h.addRooms(RoomType.Penthouse, 500, 2);

h.registerClient("Ivanov", RoomType.Single);
h.registerClient("Petrov", RoomType.Double);
h.registerClient("Sidorov", RoomType.Triple);
h.registerClient("Vasiliev", RoomType.Quad);
h.registerClient("Kuznetsov", RoomType.Penthouse);

Console.WriteLine(h.listOfFreeRoom());

Console.WriteLine(h.clientCost("Ivanov"));
Console.WriteLine(h.clientCost("Petrov"));
Console.WriteLine(h.clientCost("Sidorov"));
Console.WriteLine(h.clientCost("Vasiliev"));
Console.WriteLine(h.clientCost("Kuznetsov"));
