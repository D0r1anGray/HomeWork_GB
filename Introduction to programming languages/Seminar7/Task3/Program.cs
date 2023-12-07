// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] mass = new int[10];

int[] FillArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1,10);
    }
    return array;
}

void PrintArray(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArray(array, index - 1);
    }
}

FillArray(mass);
PrintArray(mass, mass.Length-1);