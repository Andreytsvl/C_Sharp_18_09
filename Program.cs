
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
// Clear();
// Write("Введите число A ");
// int a = int.Parse(ReadLine());
// Write("Введите число B ");
// int b = int.Parse(ReadLine());
// WriteLine(PoW(a, b));

// int PoW(int a, int b)

// {
//     if (b == 0) return 1;
//     if (b == 1) return a;
//     return (a * PoW(a, b - 1));
// }

// Семинар_10. 
// task 70 Напишите программу, которая на вход принимает два числа
// А и Б, и выдает первые Н чисел, для которых каждое следующее
// равно сумме двух предидущих
// Clear();
// Write("Введите число A ");
// int start = int.Parse(ReadLine());
// Write("Введите число B ");
// int end = int.Parse(ReadLine());
// Write("Введите длинну ряда ");
// int length = int.Parse(ReadLine());
// Write($"{start } {end} ");
// WriteLine(PrintNumber(start, end, length-2));

// string PrintNumber(int start, int end, int length)
// {
//     if (length == 0) return "";
//     return (start + end + " " + PrintNumber(end, start + end, length - 1));
// }

// task 71 В некотором машинном алфавите имеются 4 буквы а и с в
// Покажите все слова, состоящие из Н букв, которые можно 
// построить из букв этого алвавита.
// Clear();
// string chars = "аисв";
// Write("Введите число N ");
// int count = int.Parse(ReadLine());
// PrintWords(chars, count,"" );

// void PrintWords(string alfabet, int length, string prefix)
// {
//     if(length==0) WriteLine(prefix);
//     else
//     {
//         foreach (char c in alfabet) PrintWords(alfabet, length-1,prefix+c);
//     }
// }

// task 72 Заданы 2 массива info и data. В первом хранятся двоичные
// представления нескольких чисел (без разделителя). Во втором хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений 
// чисел массива data с учетом информации из массива info.
// data = {0,1,1,1,1,0,0,0,1};
// info = {2,3,3,1}
// выходные данные   1,7,0,1

Clear();
int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = new int[] { 2, 3, 3, 1 };
if (GetSum(info) != data.Length)
{
    WriteLine("Нельзя преобразовать данный массив!");
}
WriteLine(String.Join(" ", GetResultArray(data, info)));

int GetSum(int[] inArray)
{
    int sum = 0;
    foreach (int item in inArray)
    {
        sum += item;
    }
    return sum;
}

int[] GetResultArray(int[] dataArray, int[] infoArray)
{
    int[] result = new int[infoArray.Length];
    string data = String.Join("", dataArray);
    for (int i = 0; i < infoArray.Length; i++)
    {
        string substr = data.Substring(0, infoArray[i]); // метод
        result[i] = Convert.ToInt32(substr, 2);// преобразование из двоичн
        data = data.Remove(0, infoArray[i]);
    }
    return result;
}
