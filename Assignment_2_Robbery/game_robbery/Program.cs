using System;
using System.Globalization;
Console.WriteLine("Enter No of robbers: ");
int person = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the robber with whom sam will start shooting: ");
int Shoot = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the gap between robbers: ");
int gap = Convert.ToInt32(Console.ReadLine());

int[] robbers = new int[person];
int CurrentIndex = Shoot - 1;
int ShotsCompleted = 0;

for (int i = 0; i < person; i++)
{
    robbers[i] = i + 1;
}


while (person != 0)
{
    if (CurrentIndex >= person)
    {
        CurrentIndex = CurrentIndex % person;
    }

    Console.WriteLine($"Target = {robbers[CurrentIndex]} , {++ShotsCompleted} shots completed");

    for (int i = CurrentIndex; i < person - 1; i++)
    {
        robbers[i] = robbers[i + 1];
    }
    person--;
    CurrentIndex += gap;
}

Console.WriteLine(ShotsCompleted + " shots taken");

