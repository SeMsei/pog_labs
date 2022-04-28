namespace yoga;
using sport;

public class Yoga: Sport
{
    string name = "yoga";
    int numberOfExercises;
    public Yoga(int time_, int numOfExercises_): base(time_, 1) 
    {
        numberOfExercises = numOfExercises_;
        Console.WriteLine("Yoga");
    }
    public override string getName()
    {
        return name;
    }
    public override string GetNumberOfParticipant()
    {
        //Console.WriteLine("In yoga only {0} person", numberOfParticipant);
        string output = new string("In yoga only 1 person");
        return output;
    }
    public string GetNumOfExercise()
    {
        //Console.WriteLine("Number of exercises: {0}", numberOfExercises);
        string output = "Number of exercises: " + numberOfExercises.ToString();
        return output;
    }
}
