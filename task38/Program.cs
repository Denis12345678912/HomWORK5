// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 
 
void GetDifference(double [] array) 
{ 
    double maxFigures =array[0]; 
    double minFigures =array[0]; 
    double difference = 0; 
    for(int i = 0; i < array.Length; i++) 
    { 
        if(array[i] > maxFigures) 
        maxFigures = array[i]; 
        if(array[i] < minFigures) 
        minFigures = array[i]; 
    } 
    difference = maxFigures - minFigures; 
    Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + difference); 
} 
 
 
static double[] GetArray() 
{ 
    double [] newArray = new double [8]; 
    Random rand = new Random(); 
    for(int i = 0; i < newArray.Length; i++) 
    {
         newArray[i] = rand.NextDouble() * 100;
        newArray[i]= Convert.ToDouble(newArray[i].ToString("0.00"));
        
    } 
    return newArray; 
} 
 
double [] array = GetArray(); 
Console.Write($"[{String.Join(", ", array)}]"); 
Console.WriteLine(); 
GetDifference(array);