//Задайте массив заполненный случайными 
//положительными трёхзначными числами.
//Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void InputArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
       array [i]= new Random().Next(99,1000);
}
int ReleaseArray (int[] array)

{
    int count=0;
    for (int i=0; i<array.Length; i++)
        if (array [i]%2==0)
        count++;
    return count;
}    


Console.WriteLine("ВВедите кол-во элементов в массиве:");
int n=Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
Console.WriteLine($"[{string.Join (", ", array)}]");
Console.WriteLine(ReleaseArray(array));



//Задача 36: Задайте одномерный массив,
// заполненный случайными числами. 
//Найдите сумму элементов, стоящих 
//на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

void InputArrayy (int[] array2)
{
    for (int i=0; i<array2.Length; i++)
    array2 [i]= new Random().Next(0,10);
}
void ReleaseArrayy (int[] array2)

{   int sum =0; 
    for (int i=0; i<array2.Length; i++)
            if (i%2==0) 
          sum += array2[i];         
    Console.Write(sum); 
}  

Console.WriteLine("ВВедите кол-во элементов в массиве:");
int n2=Convert.ToInt32(Console.ReadLine());
int[] array2 = new int [n2];
InputArrayy (array2);
Console.WriteLine($"[{string.Join (", ", array2)}]");
ReleaseArrayy(array2);




//Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] =>
//77.15 - 1.15 = 76

void InputArrayyy (int[] array2)
{
    for (int i=0; i<array2.Length; i++)
    array2 [i]= new Random().Next(0,100);
}
void ReleaseArrayyy (int[] array2)

{   int min =100; 
    int max=0;
    int res =0;
    for (int i=0; i<array2.Length; i++)
            if (array2[i]>max) 
          max = array2[i];
            else if (array2[i]<min)   
          min = array2[i]; 
    res=max-min;      
    Console.Write(res); 
}  

Console.WriteLine("ВВедите кол-во элементов в массиве:");
int n3=Convert.ToInt32(Console.ReadLine());
int[] array3 = new int [n3];
InputArrayyy (array3);
Console.WriteLine($"[{string.Join (", ", array3)}]");
ReleaseArrayyy(array3);
