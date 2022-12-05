//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int m = 1;
string PrintNumber (int start, int end)
{
    if (start==end) return start.ToString();
    return (start + " " +PrintNumber (start + 1, end));
}
int SumNumber (int start, int end)
{
    if(start == end) return start;
return end+ SumNumber(start,end-1);
}
System.Console.WriteLine(PrintNumber(m,n));