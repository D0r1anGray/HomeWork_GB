//Задача 2: Задайте массив заполненный случайными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[15];
int count = 0;

void SeeArr(int[] arr){
    System.Console.Write("Массив: ");
    for(int i = 0; i < arr.Length; i++){
        System.Console.Write(arr[i] + " ");
    }
}

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(100,999);
    if(array[i]%2 == 0){
        count++;
    }
}
SeeArr(array);
System.Console.WriteLine("\nКоличество четных чисел в массиве = " + count);
