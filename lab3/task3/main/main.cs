// See https://aka.ms/new-console-template for more information

using System;
using dateservice;

DateService date = new DateService();
int day, month, year;
string dateString;
DateTime dt;
bool val;

Console.WriteLine("Enter date in format DD.MM.YYYY ");
dateString = Console.ReadLine();
val = DateTime.TryParse(dateString, out dt);
if (val)
{
    Console.WriteLine(date.GetDay(dateString));
    day = dt.Day;
    month = dt.Month;
    year = dt.Year;
    Console.WriteLine(date.GetDaySpan(day, month, year));
}
else
{
    Console.WriteLine("incorrect input");
}
