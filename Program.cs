/* Контрольная работа
Написать программу, которая из имеющегося массива строк
формирует новый массив строк, длина которых меньше либо равна 3 символам.
*/

Random rnd = new Random();

string[] CreateArray()
{
    int size = rnd.Next(3, 10);
    string[] array = new string[size];
    
    for (int i = 0; i < size; i++)
        array[i] = Convert.ToString(rnd.Next(0, 10000));
    
    return array;
}

int GetNewSize(string[] array)
{
    int newSize = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) newSize++;
    
    return newSize;
}

string[] CreateNewArray(string[] existArray)
{
    int newSize = GetNewSize(existArray);
    string[] newArray = new string[newSize];
    int index = 0;

    for (int i = 0; i < existArray.Length; i++)
        if (existArray[i].Length <= 3)
        {
            newArray[index] = existArray[i];
            index++;
        }

    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
            Console.Write(", ");
    }

    if (array.Length > 0)
        Console.WriteLine();
}

string[] array = CreateArray();
Console.WriteLine("В имеющемся массиве:");
ShowArray(array);

Console.WriteLine("Элементы с длиной 3 и меньше символов:");
string[] newArray = CreateNewArray(array);
ShowArray(newArray);
if (newArray.Length == 0)
    Console.WriteLine("(отсутствуют)");