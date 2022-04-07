namespace hostel
{
public class Rate
{
    private int cost_;
    public int getCost()
    {
        return cost_;
    }
    public void setCost(int _cost)
    {
        cost_ = _cost;
    }
    public Rate()
    {}
    public Rate(int rate_)
    {
        cost_ = rate_;
    }
    public void IncCost(int change_)
    {
        cost_ += change_;
    }
    public void DecCost(int change_)
    {
        cost_ -= change_;
    }

}
}