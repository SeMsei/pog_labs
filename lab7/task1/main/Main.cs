// See https://aka.ms/new-console-template for more information
using System;
using set;

Console.WriteLine("Hello, World!");

Set s1 = new Set();
Set s2 = new Set(2);
Set s3 = new Set(3, 'c');
Set s4 = new Set("qwerty");
Set s6 = new Set("qwe");

Console.WriteLine("s1 - {0}", s1.ToString());
Console.WriteLine("s2 - {0}",s2.ToString());
Console.WriteLine("s3 - {0}",s3.ToString());
Console.WriteLine("s4 - {0}",s4.ToString());
Console.WriteLine("s6 - {0}",s6.ToString());

if (s1)
{
    Console.WriteLine("s1 Not empty");
}
else
{
    Console.WriteLine("s1 Empty");
}
if (s2)
{
    Console.WriteLine("s2 Not empty");
}
else
{
    Console.WriteLine("s2 Empty");
}
if (s3)
{
    Console.WriteLine("s3 Not empty");
}
else
{
    Console.WriteLine("s3 Empty");
}
if (s4)
{
    Console.WriteLine("s4 Not empty");
}
else
{
    Console.WriteLine("s4 Empty");
}
if (s6)
{
    Console.WriteLine("s6 Not empty");
}
else
{
    Console.WriteLine("s6 Empty");
}

if (s3 == s4)
{
    Console.WriteLine("s3 Equal s4");
}
else
{
    Console.WriteLine("s3 Not equal s4");
}

if (s3!=s4)
{
    Console.WriteLine("s3 Not equal s4");
}
else
{
    Console.WriteLine("s3 Equal s4");
}

Set s5 = s3+s4;
Console.WriteLine("s3 + s4 = {0}", s5);

s5 = s4 - s6;
Console.WriteLine("s4 - s6 = {0}", s5);

s5 = s4 * s6;
Console.WriteLine("s4 * s6 = {0}", s5);