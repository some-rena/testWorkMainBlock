
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System.ComponentModel.DataAnnotations;

int getLenghtNewArray(string[] arr)
{
    int len = 0;
    foreach (var item in arr)
    {
        if (item.Length <= 3)
        {
            len++;
        }
    }
    return len;
}

string[] getArrayThreeSymbols(string[] inputArr)
{
    int lenArr = getLenghtNewArray(inputArr);

    string[] arrThreeSymbols = new string[lenArr];
    return arrThreeSymbols;
}


string[] array = { "Hello", "2", "world", ":-)" };
string[] arrayThreeSymbols = getArrayThreeSymbols(array);








