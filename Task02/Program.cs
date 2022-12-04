// Задача 2
// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.WriteLine($"{message} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int x1 = Prompt("Enter x1");
int x2 = Prompt("Enter x2");

int y1 = Prompt("Enter y1");
int y2 = Prompt("Enter y2");

int z1 = Prompt("Enter z1");
int z2 = Prompt("Enter z2");



double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

Console.WriteLine($"Distance between dotes = {distance:f2}");
