using System;

//string name = "100";
//int points = 100;
//points = +1;
//Console.WriteLine(name + name);
//Console.WriteLine(points + points);
//Console.ReadLine();

int points = 0;
string choice;

Console.WriteLine("Fråga1");
choice = Console.ReadLine();

choice = choice.ToLower();

if (choice == "a")
points += 1;

if (choice == "b")
points += 0;

if (choice == "c")
points += 0;



Console.WriteLine("Fråga2");
choice = Console.ReadLine();

if (choice == "a")
points += 0;

if (choice == "b")
points += 1;

if (choice == "c")
points += 0;



Console.WriteLine("Fråga3");
choice = Console.ReadLine();

if (choice == "a")
points += 0;

if (choice == "b")
points += 0;

if (choice == "c")
points += 1;

Console.WriteLine("Poäng");
Console.WriteLine(points);
choice = Console.ReadLine();