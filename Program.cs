//Задача 47. Задайте двумерный массив 
//размером m×n, заполненный случайными 
//вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9


void InputArray(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
   matrix[i, j] = Math.Round(new Random().NextDouble()*10, 1);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}

}



Console.Write("Введите размеры матрицы для задачи 47: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputArray(matrix);





//Задача 50. Напишите программу, которая
// на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение 
//этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет



void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(0, 10);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}

}

void ReleaseMatrix(int[,] matrix)
{
  Console.Write("Введите позицию элемента: "); 
  int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
  {
  for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
        {
        if (i == size[0] && j==size[1])
        Console.WriteLine($"{matrix[i,j]}");
         //else if (i > size[0] || j>size[1])
         //Console.WriteLine("такого элемента нет");
         }
    }
  }
}




Console.Write("Введите размеры матрицы для задачи 50: "); 
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
InputMatrix(matrix2); 
Console.WriteLine("\n");
ReleaseMatrix(matrix2);



//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;
//3.


void InputArray3(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(0, 10);
Console.Write($"{matrix[i, j]} \t");
}
Console.WriteLine();
}
}

void ReleaseMatrix3(int[,] matrix)
{
  double sum = 0;
  double avg=0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    if (j==0)
      sum += matrix[i, j];
      avg=sum/matrix.GetLength(0);
    }
    Console.WriteLine(Math.Round(avg, 1));
  } 
  }


Console.Write("Введите размеры матрицы для задачи 52: ");
int[] size3 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix3 = new int[size3[0], size3[1]];
InputArray3(matrix3);
Console.Write("\n");
ReleaseMatrix3(matrix3);

