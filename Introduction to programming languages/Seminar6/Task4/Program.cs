// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.

System.Console.Write("Введите несколько слов через пробел: ");
string[] strings = Console.ReadLine().Split(' ');

string ReverseString(string[] str){
    string strok = string.Empty;
    for(int i = 0; i < str.Length; i++){
        strok = str[i] +" "+ strok;
    }
    return strok;
}

System.Console.WriteLine(ReverseString(strings));
