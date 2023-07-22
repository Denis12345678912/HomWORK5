// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void GetEvenNumbers(int [] array)
{
    int count=0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] %2 ==0)
        count++;
    }
    Console.WriteLine("Количество чётных элеметов массива, равно " + count);
}

int[] GetArray()
{
    int [] newArray = new int [8];
    Random rand = new Random();
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(100, 1000);
    }
    return newArray;
}

int [] array = GetArray();
Console.Write($"[{String.Join(",", array)}]");
Console.WriteLine();

GetEvenNumbers(array);

