//Задача64
//Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers64 (int nummberN)

{
   Console.Write(nummberN + " ");
   if (nummberN>1) ShowNumbers64 (nummberN-1);
}
int num3=7;
Console.WriteLine("N=" +num3 );

ShowNumbers64( num3 );


 //Задача66:Задайте значения M и N. Напишите программу,
 // которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine();
int FindSum(int M,int N)
{
   if (M==N) return N;
   else return FindSum(M,N-1)+N;
}  
Console.WriteLine (FindSum (1,5));

//Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int FunctionAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return FunctionAckermann(m - 1, 1);
    }
    else
    {
        return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
    }
}
Console.WriteLine(FunctionAckermann(3, 2));

