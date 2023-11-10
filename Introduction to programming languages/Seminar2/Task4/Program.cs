//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
using System.ComponentModel.DataAnnotations;

System.Console.WriteLine("Введите натуральное число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0){
    System.Console.WriteLine("Вы ввели не натуральное число. Перезапустите программу");   
}
else{
    System.Console.WriteLine("Цифры натурального числа через запятую, начиная с единиц");
    while (n/10 != 0){
        System.Console.Write(n%10 + ",");
        n = n/10;
    }
    System.Console.Write(n%10); 
}