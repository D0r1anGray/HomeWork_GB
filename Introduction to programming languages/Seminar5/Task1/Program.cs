//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
using System.Diagnostics;
using System.Globalization;

int[,] matrix = new int[10,10];

for(int l = 0; l < matrix.GetLength(1); l++){
    System.Console.Write(l + " ");
}
System.Console.WriteLine();
for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(1,10);
        System.Console.Write(matrix[i,j] + " ");
    }
System.Console.WriteLine("|"+ i);
}

void Position(int x, int y){
    if(x < matrix.GetLength(0) && y < matrix.GetLength(1)){
        System.Console.WriteLine($"Элемент на позиции ({x};{y}) = {matrix[x,y]}");
    }
    else{
        System.Console.WriteLine("Позиция вышла за край матрицы");
    }
}
int x, y = 0;
System.Console.Write("Введите координату Х элемента: ");
x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y элемента: ");
y = Convert.ToInt32(Console.ReadLine());
Position(x, y);