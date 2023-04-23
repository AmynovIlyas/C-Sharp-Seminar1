// Задача. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 --> Среда
// 5 --> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("День недели - Понедельник");
}
else if (number == 2) // Почему-то в C# пишем так - else if; из урока понял, что в Python как-то по-другому
{
    Console.WriteLine("День недели - Вторник");
}
else if (number == 3)
{
    Console.WriteLine("День недели - Среда");
}
else if (number == 4)
{
    Console.WriteLine("День недели - Четверг");
}
else if (number == 5)
{
    Console.WriteLine("День недели - Пятница");
}
else if (number == 6)
{
    Console.WriteLine("День недели - Суббота");
}
else if (number == 7)
{
    Console.WriteLine("День недели - Воскресенье");
}
else // Эта условие учитывает все остальные варианты, не перечисленные выше
{
    Console.WriteLine("Такого дня недели не существует!");
}

