// See https://aka.ms/new-console-template for more information
using System;
using set;

Console.WriteLine("Hello, World!");

Set s1 = new Set();
Set s2 = new Set(2);
Set s3 = new Set(3, 'c');
Set s4 = new Set("qwerty");

Console.WriteLine(s3);
Console.WriteLine(s4);

Console.WriteLine("Equel: {0}", (s3 == s4));
Console.WriteLine("Not equel: {0}", (s3 != s4));

s4 += s3;
Console.WriteLine(s4);

