﻿// Задача. Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратным корнем второго.
// a = 25, b = 5 --> да
// a = 2, b = 10 --> нет
// a = 9, b = -3 --> да
// a = -3, b = 9 --> нет

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (b*b == a) 
    { // Когда в ветках после условия имеется только одно действие, фигурные скобочки можно ставить, 
    // а можно и не ставить (как и в данной программе, если убрать фигурные скобочки, то ничего не поменяется)
        Console.WriteLine("Первое число является квадратом второго");
    }
else // Важно данную программу составлять с условием "else", так как без этого условия, 
// в случае если первое число ЯВЛЯЕТСЯ квадратом второго, то на выходе будет ответ Да и Нет одновременно
    {
    Console.WriteLine("Первое число НЕ является квадратом второго");
    }
