
// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру данного числа.
/*
int FindBiggestDigit(int number);

{
int ed = number % 10;
int dec number / 10;

if (ed >dec) 
{
return ed;
}
else
{
return dec;
}
}
*/



// Задача 1. Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру данного числа.

int FindBiggestDigit(int number);    

{
    int ed = number % 10;
    int dec = number / 10;
    int max;

    if (ed >dec) 
      max = ed;

    else
      max = dec;

    return max;
}


Console.Write("Random two digit number is ");

int randomNumber = new Random().Next(10,100);

int biggestDigit = FindBiggestDigit(randomNumber);

Console.WriteLine($"Biggest digit of {randomNumber} is {biggestDigit}");

