using System;

namespace Menu;
public class menu
{
    public bool isActive()
    {
        Console.WriteLine("==MENU==");
        Console.WriteLine("Enter the number:");
        Console.WriteLine("1. Enter new point");
        Console.WriteLine("2. Exit");

        int action, x, y, output;
        bool act = int.TryParse(Console.ReadLine(), out action);

        if (act)
        {
            switch(action)
            {
                case 1:
                    Console.WriteLine("Enter new point: ");
                    bool flx = int.TryParse(Console.ReadLine(), out x);
                    bool fly = int.TryParse(Console.ReadLine(), out y);
                    if (flx && fly)
                    {
                        output = isInside(x,y);
                        if (output==1)
                        {
                            Console.WriteLine("point is inside");
                            return true;
                        }
                        else if (output==2)
                        {
                            Console.WriteLine("Point is on the board");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Point is outside");
                            return true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("incorrect input. Try again");
                        return true;
                    }
                case 2:
                    Console.WriteLine("Exiting...");
                    return false;
                default:
                    Console.WriteLine("Incorrect input. Try Again");
                    return true;
            }
        }
        else 
            {
                Console.WriteLine("incorrect input. Try again");
                return true;
            }

    }

    public int isInside(int x, int y)
    {
        if (x>50 || x<-50 || y>25 || y<-25)
            return 0;
        else if (x == -50 || x == 50 || y==-25 || y==25)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
}
