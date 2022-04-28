// See https://aka.ms/new-console-template for more information
using System;
using sport;
using yoga;
using racing;

Yoga yoga = new Yoga(30, 10);
yoga.Start();
Console.WriteLine(yoga.GetNumberOfParticipant());
Console.WriteLine(yoga.GetNumOfExercise());

Racing racing = new Racing(30, 10, 10);
racing.Start();
Console.WriteLine(racing.GetNumberOfParticipant());
Console.WriteLine(racing.GetNumOfLap());


