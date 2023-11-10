//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
System.Console.WriteLine("Введите целое число: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a%7 == 0 && a%23 == 0){
    System.Console.WriteLine("Число " + a + " одновременно кратно 7 и 23");
}
if (a%7 == 0 && a%23 != 0){
    System.Console.WriteLine("Число " + a + " кратно 7, но не кратно 23");
}
if (a%7 != 0 && a%23 == 0){
    System.Console.WriteLine("Число " + a + " кратно 23, но не кратно 7");
}
else{
    System.Console.WriteLine("Число " + a + " не кратно ни 7, ни 23");
}