//Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

//Не слишком ли много циклов?

int[,] matrix = new int[10,11];

System.Console.WriteLine("Матрица: ");

for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(1,10);
        System.Console.Write(matrix[i,j] + " ");
    }
System.Console.WriteLine();
}

// System.Console.WriteLine();
// Console.WriteLine(matrix.GetLength(0));

int[,] ReplaceStrings(int[,] matr){
    int[] temp = new int[matr.GetLength(1)];
    for(int i = 0; i < matr.GetLength(1);i++){
        temp[i] = matr[0,i];
        matr[0,i] = matr[matr.GetLength(0) - 1,i];
        matr[matr.GetLength(0) - 1,i] = temp[i];
    }
    return matr;
}

void ViewMatrix(int[,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            System.Console.Write(matr[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

ReplaceStrings(matrix);
System.Console.WriteLine("\nМатрица, в которой перва и последняя строка поменялись местами: ");
ViewMatrix(matrix);