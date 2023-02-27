/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int SumNumbers(int n)  // рекурсивный метод, возвращает сумму от 1 до n
{
    if (n == 1) return 1;
    return n + SumNumbers(n-1);    
}
Console.WriteLine("Input two numbers, M and N, M < N");
int userM = Convert.ToInt32(Console.ReadLine());
int userN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (userM < userN)
Console.WriteLine(SumNumbers(userN)-SumNumbers(userM)+userM); 
// сумму в промежутке рассчитываем, как сумму от 1 до большего минус сумма от одного до меньшего чисел,
// плюс меньшее число, так как его вычли
else Console.WriteLine($"Error, {userM} not less than {userN}"); // проверка ввода
