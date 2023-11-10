//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число (можно с плавающей запятой):");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите второе число (можно с плавающей запятой):");
double b = Convert.ToDouble(Console.ReadLine());
if(a == b){
    System.Console.WriteLine("Числа равны, сравнивать нечего");
}
if(a > b){
    System.Console.WriteLine("Первое число " + a + " больше второго числа " + b);
}
if(a < b){
    System.Console.WriteLine("Первое число " + a + " меньше второго числа " + b);
}
