//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
System.Console.WriteLine("Напишите координату точки X:");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Напишите координату точки Y:");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0){
    System.Console.WriteLine("Точка в Первой четверти");
}
if (x < 0 && y > 0){
    System.Console.WriteLine("Точка во Второй четверти");
}
if (x < 0 && y < 0){
    System.Console.WriteLine("Точка в Третьей четверти");
}
if (x > 0 && y < 0){
    System.Console.WriteLine("Точка в Четвёртой четверти");
}
else{
    System.Console.WriteLine("X или Y равны 0. Перезапустите программу");
}