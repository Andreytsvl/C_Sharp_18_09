
using System;
using static System.Console;
// task 63 Задайте число Н. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до Н.
// Clear();
// Write("Введите число N ");
// int n = int.Parse(ReadLine());
// WriteLine(RowNumber(1,n));


// string RowNumber(int i, int n)
// {
//     if(i==n) return i.ToString();
//     return(i + " " + RowNumber(i+1,n));
// }

// task 65 Задайте числа М и Н. Напишите программу, которая выведет все
// натуральные числа в промежутке от М до Н.
// Clear();

// Write("Введите число M ");
// int m = int.Parse(ReadLine());
// Write("Введите число N ");
// int n = int.Parse(ReadLine());
// WriteLine(RowNumber(m,n));


// string RowNumber(int m, int n)
// {
//     if(m==n) return m.ToString();
//     return(m + " " + RowNumber(m+1,n));
// }

// task 65 Напишите программу, которая на вход
// принимает число и возвращает сумму цифр числа.
// Clear();
// Write("Введите число N ");
// int n = int.Parse(ReadLine());
// WriteLine(SumDigit(n));

// int SumDigit(int n)
// {
//     if (n == 0) return 0;
//     return (n % 10 + SumDigit(n / 10));
// }

// task 65 Напишите программу, которая на вход принимает два числа
// А и Б, и возводит число А в целую степень Б с помощью рекурсии.
Clear();
Write("Введите число A ");
int a = int.Parse(ReadLine());
Write("Введите число B ");
int b = int.Parse(ReadLine());
WriteLine(PoW(a, b));

int PoW(int a, int b)

{
    if (b == 0) return 1;
    if (b == 1) return a;
    return (a * PoW(a, b - 1));
}