// Задача 10: Напишите программу, которая 
//принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Console.Clear ();
//int a1= new Random().Next(100,1000);
//Console.WriteLine(a1);
//int x1=a1/10;
//int x11=x1%10;
//Console.WriteLine(x11);

//Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6



  
//Console.WriteLine("Введите число:");
//int n = Convert.ToInt32(Console.ReadLine());

// if (n<100)
//  Console.WriteLine("нет третьего числа");
// else if (n<1000)
//   n=n%10;
//
// else if (n<10000)
//   n=n%100/10;
// 
//else 
// n=n%1000/100;  
//Console.WriteLine(n);   
//Задача 15: Напишите программу,
// которая принимает на вход цифру,
//обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
//int a = Convert.ToInt32(Console.ReadLine());

//if (a == 1 || a==2 || a==3 || a==4 || a==5 )
//Console.WriteLine("no");
//else if (a == 6 || a == 7)
//Console.WriteLine("yes");
//else
//Console.WriteLine("Неверное число");

//Задача 19
//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да  

Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int n1 = a/10000;
int n2 = a%10;
int n3 = a/1000%10;
int n4 = a%100/10;
if (n1==n2 && n3==n4)
 {
 Console.WriteLine("да");
 }
else
 {
  Console.WriteLine("нет");
 }

//Задача 21
//Напишите программу, которая принимает 
//на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("x1=");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1=");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1=");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("x2=");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2=");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2=");
int z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow (x1-x2,2)+Math.Pow (y1-y2,2)+Math.Pow (z1-z2,2)),2));


//Задача 23
//Напишите программу, которая принимает
// на вход число (N) и выдаёт таблицу кубов
// чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("N= ");
int a3 = Convert.ToInt32(Console.ReadLine());
for ( int i = 1; i <= a3; i++)
 Console.WriteLine($"{Math.Pow(i,3)}");

