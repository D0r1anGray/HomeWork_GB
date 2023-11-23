//Задача 4: Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа.
//Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем.
//Размер массива должен быть равен количеству цифр.

int N = new Random().Next(1,100000);

String l = Convert.ToString(N);
int[] massiv = new int[l.Length];

System.Console.WriteLine("Натуральное число: " + N);
//int L = l.Length;
int i = 1;

while(i < l.Length){
    massiv[l.Length - i] = N%10;
    N = N/10;
    i++;
}
massiv[0] = N%10;

i = 0;
System.Console.Write("Массив: ");
while(i < l.Length){
    System.Console.Write(massiv[i] + " ");
    i++;
}
System.Console.WriteLine("\nПервый элемент массива: " + massiv[0] + ". Последний элемент массива: " + massiv[l.Length - 1] +
 ". Размер массива: " + massiv.Length);
