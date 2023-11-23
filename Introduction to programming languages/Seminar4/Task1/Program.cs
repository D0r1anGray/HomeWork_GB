//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//Не смог толком реализовать проверку на целое число(

int Sum(string z){
    int sum = 0;
    for(int i = 0; i < z.Length; i++){
        sum = sum + Convert.ToInt32(z[i]);
    }
    return sum;
}

while(true){
    System.Console.Write("Введите целое число: ");
    string? z = Console.ReadLine();
    if(z.ToLower() == "q" || Sum(z)%2 == 0){
        break;
    }
}

