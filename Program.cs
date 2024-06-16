
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.ComponentModel.DataAnnotations;

string[] array = { "Hello", "2", "world", ":-)" };

int len = 0;
foreach (var item in array)
{
    if (item.Length <= 3)
    {
        len++;

    }
}
string[] arrayThreeSymbols = new string[len];
int correntIndex = 0;
foreach (var item in array)
{
    if (item.Length <= 3)
    {
        arrayThreeSymbols[correntIndex] = item;
        correntIndex++;
    }
}
Console.Write("[");
for (int i = 0; i < arrayThreeSymbols.Length; i++)
{
    if (i == arrayThreeSymbols.Length - 1)
    {
        Console.Write($"\"{arrayThreeSymbols[i]}\"");
    }
    else
    {
        Console.Write($"\"{arrayThreeSymbols[i]}\", ");
    }
}
Console.Write("]");

///








