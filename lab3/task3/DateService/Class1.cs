namespace dateservice;
public class DateService
{
    public string GetDay(string date)
    {
        int day, month, year;
        day = int.Parse(date.Substring(0,2));
        month = int.Parse(date.Substring(3,2));
        year = int.Parse(date.Substring(6));
        DateTime dt = new DateTime(year, month, day);
        return dt.ToString("dddd");
    }

    public int GetDaySpan(int day, int month, int year)
    {
        DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        DateTime dt1 = new DateTime(year, month, day);
        return  (int) Math.Ceiling(Math.Abs((dt-dt1).TotalDays));
    }


}
