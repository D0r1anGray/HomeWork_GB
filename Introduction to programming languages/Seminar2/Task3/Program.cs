//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
System.Console.WriteLine("Введите число из отрезка 10 - 99");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 && a > 9){
    if (a/10 > a%10){
        System.Console.WriteLine("Наибольшая цифра " + a/10);
    }
    if (a/10 < a%10){
        Console.WriteLine("Наибольшая цифра " + a%10);
    }
    if (a/10 == a%10){
        System.Console.WriteLine("Цифры в числе равны, наибольшего нет");
    }
}
else{
    System.Console.WriteLine("Число вне диапазона! Перезапустите программу");
}