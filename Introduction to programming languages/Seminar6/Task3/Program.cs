// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

System.Console.Write("Введите строку: ");
string str = Console.ReadLine();

void CheckPalindrome(string strok){
    int count = 0;
    for(int i = 0; i < strok.Length/2; i++){
        if(strok[i] == strok[strok.Length-1 -i]){
            count++;
        }
    }
    if(count == strok.Length/2){
        System.Console.WriteLine("Слово палиндром!");
    }
    else{
        System.Console.WriteLine("Слово НЕ палиндром!");
    }
}

CheckPalindrome(str);