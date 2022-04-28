namespace racing;
using sport;

sealed public class Racing: Sport
{
    string name = "racing";
    int numOfLap;
    public Racing(int time_, int numOfParticipant_, int numOfLap_): base(time_, numOfParticipant_)
    {
        numOfLap = numOfLap_;
        Console.WriteLine("Racing");
    }
    public override string getName()
    {
        return name;
    }
    public new void Start()
    {
        Console.WriteLine("Racing start");
    }
    public string GetNumOfLap()
    {
        //Console.WriteLine("Number of lap: {0}", numOfLap);
        string output = "Number of lap: " + numOfLap.ToString();
        return output;
    }
}
