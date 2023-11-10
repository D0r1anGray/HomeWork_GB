//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите первое число:");
double maxim = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите второе число:");
double second = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите третье число:");
double third = Convert.ToDouble(Console.ReadLine());

if(maxim == second || maxim == third){
    System.Console.WriteLine("Числа должны быть различны! Перезапустите программу");
}

if(maxim < second){
    maxim = second;
    if(maxim > third){
        System.Console.WriteLine("Второе число " + maxim + " максимальное из трёх");
    }
}
if(maxim < third){
    maxim = third;
    System.Console.WriteLine("Третье число " + maxim + " максимальное из трёх");
}
if(maxim > second && maxim > third){
    Console.WriteLine("Первое число " + maxim + " максимальное из трёх");
}

