namespace hostel;

using room;
using client;

public class Hostel
{
    Room[] rooms;
    int num_client=0, num_room=0;
    Client[] clients;
    public Hostel(int num_room ,int num_client)
    {
        rooms = new Room[num_room];
        clients = new Client[num_client];
    }
    public void addRooms(RoomType type, int cost, int num=1)
    {
        for (int i=num_room; i<num_room+num; i++)
        {
            rooms[i]=new Room(type, cost);
            //Console.WriteLine(cost);
        }
        num_room+=num;
    }
    public bool registerClient(string surname, RoomType type)
    {
        if (clientCost(surname)!=-1)
        {
            return false;
        }
        for (int i=0; i<num_room; i++)
        {
            if (rooms[i].Type==type && rooms[i].isFree())
            {
                clients[num_client]=new Client(surname, type, rooms[i].Cost);
                rooms[i].setBusy();
                num_client++;
                return true;
            }
        }
        return false;
    }
    public string listOfFreeRoom()
    {
        string s="";
        for (int i=0; i<num_room; i++)
            if (rooms[i].isFree())
                s+=Convert.ToString(i)+" "+Convert.ToString(rooms[i].Type)+" "+Convert.ToString(rooms[i].Cost)+"\n";
        return s;
    }
    public int clientCost(string surname)
    {
        for (int i=0; i<num_client; i++)
            if (clients[i].Surname==surname)
                return clients[i].Cost;
        return -1;
    }

}
