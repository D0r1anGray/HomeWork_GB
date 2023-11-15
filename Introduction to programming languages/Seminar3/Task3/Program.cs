//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//Найдите разницу между максимальным и минимальным элементов массива.
double[] massiv = new double[5];

int i = 0;
System.Console.WriteLine("Введите поочерёдно вещественное значение каждого элемента массива:");
while(i < massiv.Length){
    System.Console.WriteLine("Введите значение " + (i+1) + " элемента массива: ");
    massiv[i] = Convert.ToDouble(Console.ReadLine());
    i++;
}
i = 0;

double max = massiv[0];
double min = massiv[0];
System.Console.Write("Массив: ");
while(i < massiv.Length){
    if(massiv[i] > max){
        max = massiv[i];
    }
    if(massiv[i] <= min){
        min = massiv[i];
    }
    System.Console.Write(massiv[i] + " ");
    i++;
}
System.Console.WriteLine("Максмум: " + max + " Минимум: " + min);
System.Console.WriteLine("Разница между максимальным и минимальным значением массива: " + (max - min));