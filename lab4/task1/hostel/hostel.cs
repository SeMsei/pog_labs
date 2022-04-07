namespace hostel
{
public class Hostel
{
    private static Hostel hostelInstance;

    private Rate rate;
    private string name;
    public string getName()
    {
        return this.name;
    }
    private int numberOfRooms;
    public int getNumberOfRooms()
    {
        return hostelInstance.numberOfRooms;
    }
    private int numberOfOccupiedRooms;
    public int getNumberOfOccupiedRooms()
    {
        return hostelInstance.numberOfOccupiedRooms;
    }
    private int cost;

    public int getCost()
    {
        return hostelInstance.rate.getCost();
    }
    public void IncCost(int change_)
    {
        hostelInstance.rate.IncCost(change_);
    }
    public void DecCost(int change_)
    {
        this.rate.DecCost(change_);
    }

    public Hostel()
    {}
    private Hostel (string name, int numberOfRooms, int numberOfOccupiedRooms, int cost)
    {
        
        this.name=name;
        this.numberOfRooms=numberOfRooms;
        this.numberOfOccupiedRooms=numberOfOccupiedRooms;
        this.rate = new Rate(cost);
        //Console.WriteLine("----------{0}", this.name);
    }
    
    public void build(string name = "Grand Plaza", int numberOfRooms=100, int numberOfOccupiedRooms=0, int cost=1000)
    {
        //Console.WriteLine("{0}", numberOfOccupiedRooms);
        hostelInstance = GetInstance(name, numberOfRooms, numberOfOccupiedRooms, cost);
        //Console.WriteLine("----------{0}", hostelInstance.name);
    }
    public static Hostel GetInstance(string name = "Grand Plaza", int numberOfRooms=100, int numberOfOccupiedRooms=0, int cost=1000)
    {
        //Console.WriteLine("Building");
        if (hostelInstance == null)
        {
            hostelInstance = new Hostel(name, numberOfRooms, numberOfOccupiedRooms, cost);
        }
        //Console.WriteLine("----{0}", hostelInstance.rate.getCost());
        return hostelInstance;
    }
    public int Income()
    {
        //Console.WriteLine("{0}", hostelInstance.rate.getCost());
        return hostelInstance.rate.getCost()*hostelInstance.numberOfOccupiedRooms;
    }
}
}
