// Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = new int[6,15];

for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(1,10);
        System.Console.Write(matrix[i,j] + " ");
    }
System.Console.WriteLine();
}

void MinSumElements(int[,] matr){
    int min = 0;
    for(int i = 0; i < matr.GetLength(0);i++){
        int summa = 0;
        for(int j = 0; j< matr.GetLength(1);j++){
            summa = summa + matr[i,j];
        }
        System.Console.WriteLine("Сумма строки = " + summa);
        while(min == 0){
            min = summa;
        }
        if(summa < min){
            min = summa;
        }
    }
    Console.WriteLine("Минимальная сумма строки= " + min);
}

MinSumElements(matrix);
