// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System.Diagnostics;

Console.Write("Введите число M как начало промежутка: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N как конец промежутка: ");
int n = Convert.ToInt32(Console.ReadLine());

void ReturnNatural(int beg, int end){
    if(beg >= end || beg < 0 || end < 0){
        return;
    }
    else{
        Console.Write(beg + " ");
        ReturnNatural(beg +1, end);
    }
}

ReturnNatural(m, n);




