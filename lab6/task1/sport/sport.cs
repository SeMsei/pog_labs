namespace sport;
using System;
public abstract class Sport
{
    public int numberOfParticipant;
    public int time;
    protected Sport(int time_, int numOfParticipant_)
    {
        numberOfParticipant = numOfParticipant_;
        time = time_;
        Console.WriteLine("Sport");
    }
    public abstract string getName();
    public void Start()
    {
        Console.WriteLine("Sport start");
    }
    public virtual string GetNumberOfParticipant()
    {
        //Console.WriteLine("Number of participants: {0}", numberOfParticipant);
        string output = "Number of participants: " + numberOfParticipant.ToString();
        return output;
    }

    public int GetTime()
    {
        return time;
    }
}
