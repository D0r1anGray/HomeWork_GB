//Задача З: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
System.Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0){
    System.Console.WriteLine("Число " + number + " четное!");
}
else{
    System.Console.WriteLine("Число " + number + " нечетное!");
}

