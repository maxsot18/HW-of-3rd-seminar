// Задача 1

// Напишите программу, 
// которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да
int Prompt(string message)
{
    Console.WriteLine($"{message} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Prompt("Enter a five digit number ");

if(number > 10000 & number < 100000)
{
   int Thouthands = number / 10;
   int without1number = number - (number / 10000 * 10000);
   
   if(number % 10 == number / 10000 & Thouthands % 10 == without1number / 1000 )
   {
    Console.WriteLine($"{number} is palindrome");
   }
   else
   {
    Console.WriteLine($"{number} isn't palindrome");  
   }
}

 else
 {
     Console.WriteLine($"{number} not five digit number");
 }