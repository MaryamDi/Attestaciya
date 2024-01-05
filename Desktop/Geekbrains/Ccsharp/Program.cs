//Задание 1. Совместная работа
//Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 => да a = 2, b = 10
//a = 9, b = -3
//a = -3, b = 9
//=> нет => да => нет

//Console.Write("Введите первое число: ");
//int number1 = int.Parse (Console.ReadLine());
//Console.Write("Введите второе число: ");
//int number2 = int.Parse (Console.ReadLine());
//if (number2*number2 == number1) 
//{
//    Console.WriteLine("Является");
//}
//else Console.WriteLine("Не является");

//Напишите программу, которая на вход принимает целое число N, а на выходе показывает все целые числа в промежутке от -N до N.
//Console.WriteLine("Введите число: ");
//int num = int.Parse(Console.ReadLine());
//if (num < 0)
//{
  //  num = num * (-1);
//}
//int counter = - num;
//while (counter <= num)
//{
  //  Console.Write($" { counter} " );
    //counter++;
//}
//Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму первой и последней цифры этого числа.
//Сначал считаем число с консоли
int input = int.Parse (Console.ReadLine());
//Теперь нам нужно получить первую и последнюю цифры, это можно сделать с помощью опрерации
//остаток от деления - A%B
int DecimalLeftover = input%100;
int FirstNumber = input-DecimalLeftover;
//Получаем остаток от деления, вычтя остаток от деления получаем по сти деление без остатка
FirstNumber = FirstNumber/100;
//Т.к. у нас будет лежать именно первыя цифра и два нуля.
//Теперь получим третью циффу, это остаоок от деления на 10
int LastNumber = input%10;
int Result = FirstNumber + LastNumber;
Console.WriteLine(Result);

