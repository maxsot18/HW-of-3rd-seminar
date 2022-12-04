// Задача 3

// Напишите программу, которая 
// принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.WriteLine($"{message} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Enter a number");
for(int i = 1; i <= number; i++)
{
   int cube = i * i * i;
   Console.WriteLine($"{cube}");
}



