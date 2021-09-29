using System;

//string name = "100";
//int points = 100;
//points = +1;
//Console.WriteLine(name + name);
//Console.WriteLine(points + points);
//Console.ReadLine();
//while

int points = 0;
string choice = "";
points += Question_1();


Console.WriteLine("Fråga1");
choice = GetAnswer();

            static int Question_1()
            {   
            string choice = GetAnswer();
            int points = 0;
            if (choice == "a")
            points += 1;
            return points;
            }




Console.WriteLine("Fråga2");
choice = GetAnswer();

 static int Question_2()
            {   
            string choice = GetAnswer();
            int points = 0;
            if (choice == "b")
            points += 1;
            return points;
            }



choice = "";
while (choice != "a" && choice != "b" && choice != "c")
{
    Console.WriteLine("Fråga3");
    choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice == "a")
        points += 0;

    if (choice == "b")
        points += 0;

    if (choice == "c")
        points += 1;
}




Console.WriteLine("Poäng");
Console.WriteLine(points);


choice = Console.ReadLine();




  static string GetAnswer()
        {   string choice = "";
        while (choice != "a" && choice != "b" && choice != "c")
        {   choice = Console.ReadLine();
        choice = choice.ToLower();
        }return choice;}