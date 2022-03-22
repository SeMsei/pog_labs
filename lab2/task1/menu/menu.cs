namespace Menu;
public class menu
{
    public bool isActive()
    {
        Console.WriteLine("Enter number of option:\n");
        Console.WriteLine("1.Enter new number\n");
        Console.WriteLine("2.Exit");

        int action;
        bool fl = int.TryParse(Console.ReadLine(), out action);

        if (fl)
        {
            switch(action)
            {
                case 1:
                    Console.WriteLine("Enter new number:");
                    int num;
                    bool val = int.TryParse(Console.ReadLine(), out num);
                    if (val && isNumOk(num))
                    {
                        if (isSumEven(num))
                        {
                            Console.WriteLine("Sum cifr of num is even");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Sum cifr of num isn't even");
                            return true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Try again");
                        return true;
                    }
                case 2:
                    Console.WriteLine("Exiting from menu...");
                    return false;
                default:
                    Console.WriteLine("Incorrect input. Try again");
                        return true;

            }
        }
        else
        {
            Console.WriteLine("Incorrect input. Try again");
            return true;
        }
    }

    public bool isSumEven(int num)
    {
        if ((num/10+num%10)%2==0)
            return true;
        else
            return false;
    }

    public bool isNumOk(int num)
    {
        if (num%100<num)
            return false;
        else
            return true;
    }

}
