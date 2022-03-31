// See https://aka.ms/new-console-template for more information
using System;
using function;

Funct funct = new Funct();

Console.WriteLine("Enter number\n");
int z;
bool fl = int.TryParse(Console.ReadLine(), out z);

if (!fl)
{
    Console.WriteLine("incorrect input");
}
else
{
    funct.calc(z);
}
