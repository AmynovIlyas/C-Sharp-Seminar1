﻿// Задача. Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 --> 6
// 782 --> 2
// 918 --> 8

Console.WriteLine("Введите трёхзнаное число");
int number = int.Parse(Console.ReadLine()!);
if (number >= 100 & number <= 999) // Двойное неравенство (например, такое - 100 =< number <= 999) невозможно в языке C# (зато возможно в Pythone); в качестве союза "и" здесь можно использовать как однократное "&", так и двукратное "&&" (между ними есть разница, но пока что нам её знать рано)
{
    Console.WriteLine("Последней цифрой данного числа является: " + number % 10); // Можно было бы ввести дополнительную переменную (по типу result = number % 10), но в данной задаче это будет занимать лишнюю строку; введение доп переменной необходимо, если найденное число надо будет испольщовать для дальнейшего решения задачи
}
else // В ветку else никогда не надо писать условие; условие пишется в ветку if или в ветку else if;
{
    Console.WriteLine("Ошибка: Вы ввели не трехзначное число");
}