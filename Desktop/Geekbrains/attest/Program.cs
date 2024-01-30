// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

string Len(int M, int N)
{
 if (M == N || M > N) return Convert.ToString(M);
    return M + " " + Len(M+1, N);
}
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Len(M,N));

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

string Len(int m, int n)
{
 if (m == 0) return Convert.ToString(n +1);
 else if (m > 0 && n == 0) return Len(m - 1,1);
 else 
 return Len(m - 1, Convert.ToInt32(Len(m, n - 1)));
}
Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Len(m,n));

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


static void Len(int[] array, int i)
{
     if (i < array.Length)
     {
     Len(array, i + 1);
     Console.Write($"{array[i]} ");
     }
     
}
int[] array = {23, 18, 5, 7, 9, 11, 15};
int i = 0;
Len(array, i);






