// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] chars = new char[10,11];

char[,] FillCharArray(char[,] ch){
    int[,] variants = new int[ch.GetLength(0), ch.GetLength(1)];
    for(int i = 0; i < ch.GetLength(0); i++){
        for(int j = 0; j < ch.GetLength(1); j++){
            variants[i,j] = new Random().Next(1,24);
        }
    }
    char[] symbols = {'a','b','c','d','e','f','g','h','i','j','k','l','m','o','p','q','r','s','t','u','v','w','x','y','z'};
    for(int i = 0; i < variants.GetLength(0); i++){
        for(int j = 0; j < variants.GetLength(1); j++){
            for(int k = 0; k < symbols.Length; k++){
                if(variants[i,j] == k){
                    ch[i,j] = symbols[k];
                }
            }
        }   

    }
    return ch;
}

void ViewArray(char[,] ch){
    for(int i = 0; i < ch.GetLength(0); i++){
        for(int j = 0; j < ch.GetLength(1); j++){
            System.Console.Write(ch[i,j] + " ");
        }
    System.Console.WriteLine();
    }
}

string CharArrayToString(char[,] ch){
    string str = string.Empty;
    for(int i = 0; i < ch.GetLength(0); i++){
        for(int j = 0; j < ch.GetLength(1); j++){
            str = str + ch[i,j];
        }
    str = str + ' ';
    }
    return str;
}

FillCharArray(chars);
ViewArray(chars);
System.Console.WriteLine();
Console.WriteLine(CharArrayToString(chars));
