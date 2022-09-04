/*
// Задача 1. Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное само на себя)

Console.Write("Inhut a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int qard = num * num;

Console.WriteLine($"The square of {num} is {qard}");

*/
/*
// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Input ferst number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int qard2 = n2 * n2;

if (n1 == qard2)
{
    Console.WriteLine($"{n1} is qard2 of {n2}");
}
else
{
    Console.WriteLine($"{n1} is not qard2 of {n2}");
}
*/
/*
// задача 3. Напишите программу, которая на вход принимает одно чило (N), а на выходе показывает все целые числа в промежутке от отрицательной версии этого числа до самого этого числа.

Console.Write("Input integer positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);

while (current <= number)
{
   Console.Write(current + " ");
   current++; 
   }
*/
/*
// задача 4. Напишите программу, которая на вход принимает трехзначное число, а на выходе дает последнюю цифру этого числа

Console.Write("Input integer three digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ed = number % 10;

Console.WriteLine($"Last digit of {number} is {ed}");

*/