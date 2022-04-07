// See https://aka.ms/new-console-template for more information

using System;
using calculate;

Calculate calculator = new Calculate();

int num;

Console.WriteLine("Enter number\n");

bool fl = int.TryParse(Console.ReadLine(), out num);

if (!fl)
{
    Console.WriteLine("incorrect input");
}
else
{
    num = calculator.change(num);
    Console.WriteLine(num);
}

