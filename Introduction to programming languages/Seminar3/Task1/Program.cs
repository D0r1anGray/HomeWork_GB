//Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100.
//Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
int[] mass = new int[10];
int i = 0;

System.Console.Write("Массив: ");  
while (i < mass.Length){
    mass[i] = new Random().Next(1,100);
    System.Console.Write(mass[i] + " ");
    i++;
}
System.Console.WriteLine();
i = 0;
int count = 0;
while(i < mass.Length){
    if(mass[i] >= 20 && mass[i] <= 90){
        count ++;
        i++;
    }
    else{
        i++;
    }
}
System.Console.WriteLine("В пределах отрезка [20;90] лежит " + count + " элементов массива");