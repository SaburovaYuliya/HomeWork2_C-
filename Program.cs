// Задача 10: Напишите программу, которая 
//принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear ();
int a1= new Random().Next(100,1000);
Console.WriteLine(a1);
int x1=a1/10;
int x11=x1%10;
Console.WriteLine(x11);

//Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа
// или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6



  //int n21=n/10;
  //int a21=n;
  //int n22=n%10;
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

 if (n<100)
  Console.WriteLine("нет третьего числа");
 else if (n<1000)
   n=n%10;
 
 else if (n<10000)
   n=n%100/10;
   
 else 
  n=n%1000/100;  
Console.WriteLine(n);   
//Задача 15: Напишите программу,
// которая принимает на вход цифру,
//обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1 || a==2 || a==3 || a==4 || a==5 )
Console.WriteLine("no");
else if (a == 6 || a == 7)
Console.WriteLine("yes");
else
Console.WriteLine("Неверное число");

  

 
 
 
    