//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void GetSumOddNumbers(int [] array)
{
    int sumOddNumbers = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(i % 2 == 1)
        sumOddNumbers +=array[i];
    }
    Console.WriteLine("Сумма нечётных позиций массива, равна: " + sumOddNumbers);
}

int[] GetArray()
{
    int [] newArray = new int [8];
    Random rand = new Random();
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(0, 50);
    }
    return newArray;
}

int [] array = GetArray();
Console.Write($"[{String.Join(",", array)}]");
Console.WriteLine();
 GetSumOddNumbers(array);