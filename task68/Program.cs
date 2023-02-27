/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
алгоритм взял по ссылке ниже
https://www.bestprog.net/wp-content/uploads/2019/01/recursion_05r.jpg
*/
 int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}
Console.WriteLine("Input two numbers for Ackermann function, M and N.");
int userM = Convert.ToInt32(Console.ReadLine());
int userN = Convert.ToInt32(Console.ReadLine());
Console.Write("The result of Ackermann function is: ");
Console.WriteLine(AckermannFunction(userM, userN)); 