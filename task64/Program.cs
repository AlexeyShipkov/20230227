/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
void ShowNumbers(int number)
{
    Console.Write(number + " ");
    if (number > 1) ShowNumbers(number -1);
}
Console.WriteLine("Input the number");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
Console.WriteLine();