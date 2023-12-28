/* 1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной 
содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом 
(не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 
олжны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

using System.Data;
using System.Globalization;
using System.Xml.XPath;

void InputArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        count = new Random().Next(1,7);//определяем случайную позицию в массиве
        if (count ==3 && i !=0 && array[i-1] != 32)
        {
            array[i] = 32; //добваляем пробел
        }
        else
        {
        array[i] = new Random().Next(97, 123); //маленькие латинские буквы в ASCII
        }
    } 
     
}
void TransformArray(int[] array, char [] charArray)
{
 for(int i = 0; i < array.GetLength(0); i++)
    {
        charArray [i] = Convert.ToChar(array [i]); //преобразуем массив int в char
    }
}

int SizeStringArray(int[]array)
{
    int count =0;
     for(int i = 0; i < array.GetLength(0) -1 ; i++)
     {
        if (array[i] == 32)
        {
            count ++;
        }
     }
     return count;
}

int [] SpacePositions(int[]array, int sizeStringArr)
{
    int[] spacePosition = new int [sizeStringArr]; 
    int j = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] == 32 && i <array.GetLength(0)-1)
        {
            spacePosition[j] = i;
            j++;
        }
    }
    return spacePosition;

}

// string[] CharArrayToStringArray (char [] charArray, int sizeStringArr)
// {
 
// }

void PrintArray(string[] result)
{
    for(int i = 0; i < result.GetLength(0); i++)
    {
        Console.Write($"{result[i]} \t");
    }
}

Console.Clear();

int size = new Random().Next(10, 20);
int[] array = new int[size];
char[] charArray = new char[size];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

TransformArray(array,charArray);
Console.WriteLine($"Начальный массив символов: [{string.Join(", ", charArray)}]");
int sizeStringArr = SizeStringArray(array);
int[] spacePosition = SpacePositions(array,sizeStringArr);
Console.WriteLine($"массив позиций пробела: [{string.Join(", ", spacePosition)}]");

Console.WriteLine($"Размер массива {sizeStringArr}");
// string [] resultStringArray = CharArrayToStringArray(charArray, sizeStringArr);
// PrintArray(resultStringArray);
