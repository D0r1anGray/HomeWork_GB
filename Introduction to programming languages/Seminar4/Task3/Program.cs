//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
int[] array =  new int[5];

for(int i = 0; i < array.Length; i++){
    array[i] = new Random().Next(1,100);
}

void SeeArr(int[] arr){
    System.Console.Write("Массив: ");
    for(int i = 0; i < arr.Length; i++){
        System.Console.Write(arr[i] + " ");
    }
}

int[] Reverse(int[] arr){
    int temp;
    for(int i = 0; i < arr.Length/2; i++){
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
    return arr;
}

SeeArr(array);
Reverse(array);
System.Console.Write("\nПеревёрнутый ");
SeeArr(array);

