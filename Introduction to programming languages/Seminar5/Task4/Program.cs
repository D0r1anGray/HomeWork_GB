//Задача 4*(не обязательная): Задайте двумерный массив из целых чисел.
//Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
//Под удалением понимается создание нового двумерного массива без строки и столбца.
//Если минимальных элементов несколько, то брать любой из них.
int[,] matrix = new int[5,5];

for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i,j] = new Random().Next(1,10);
        System.Console.Write(matrix[i,j] + " ");
    }
System.Console.WriteLine();
}

int[,] DeleteRowAndColumn(int[,] matr){
    int[,] newmatr = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    int min = matr[0,0];
    int x = 0;
    int y = 0;
    int newRow = 0;
    int newCol = 0;
    for (int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            if(matr[i,j] < min){
                min = matr[i,j];
                x = i;
                y = j;
            }
        }
    }    
    for(int k = 0; k < matr.GetLength(0);k++){
        if(k == x){
            continue;
        }
        for(int l = 0; l < matr.GetLength(1); l++){
            if(l != y){
                newmatr[newRow,newCol] = matr[k,l];
                newCol++;
            }
        }
        newCol = 0;
        newRow++;
    }
    System.Console.WriteLine($"\nУдалена строка {x+1} и столбец {y+1}. Минимальный элемент {min}");
    return newmatr;
}

void ViewMatrix(int[,] matr){
    for(int i = 0; i < matr.GetLength(0); i++){
        for(int j = 0; j < matr.GetLength(1); j++){
            System.Console.Write(matr[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}


matrix = DeleteRowAndColumn(matrix);
System.Console.WriteLine();
ViewMatrix(matrix);
