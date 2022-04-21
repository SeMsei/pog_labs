namespace client;
using room;

public class Client
{
    string surname;
    RoomType type;
    int cost;
    public Client(string surname_, RoomType type_, int cost_)
    {
        surname=surname_;
        type=type_;
        cost=cost_;
    }
    public string Surname {get{return surname;}}
    public RoomType Type {get{return type;}}
    public int Cost {get{return cost;}}
}
