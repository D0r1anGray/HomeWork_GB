//Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] massiv = new int[10];

int i = 0;
int count = 0;
while(i < massiv.Length){
    massiv[i] = new Random().Next(1,100);
    if(massiv[i] % 2 == 0){
        count++;
    }
    i++;
}
i = 0;

System.Console.Write("Массив: ");
while(i < massiv.Length){
    System.Console.Write(massiv[i] + " ");
    i++;
}
System.Console.WriteLine("\nКоличество четных чисел в массиве: " + count);
