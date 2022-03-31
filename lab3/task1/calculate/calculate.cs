namespace calculate;
public class Calculate
{
    public int change(int num)
    {
        if (num%2==0)
        {
            num/=2;
        }
        else
        {
            num+=3;
        }
        return num;
    }
}
