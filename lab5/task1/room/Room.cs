namespace room;

public enum RoomType{
    Single,
    Double,
    Triple,
    Quad,
    Penthouse
}

public class Room
{
    RoomType type;
    int cost;
    bool free;
    public Room(RoomType type, int cost)
    {
        this.type=type;
        this.cost=cost;
        Console.WriteLine(cost);
        free=true;
    }
    public bool isFree()
    {
        return free;
    }
    public void setBusy()
    {
        free=false;
    }
    public void setFree()
    {
        free=true;
    }
    public int Cost {get{return cost;}}
    public RoomType Type {get {return type;}}
}
