// Задача: Написать программу, которая из имеющегося массива строк формирует
// массив из строк формирует массив из строк, длина которых меньше либо равна
// 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями
// лучше обойтись исключительно массивамию
// Примеры: 
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"]->["-2"]
// ["Russia", "Denmark", "Kazan"] -> [] 

string[] firstArray = new string[5] {"hello", "2", "world", ":-)", "Russia"};
string[] secondArray = new string[firstArray.Length];
int count = 0;
void SecondArray(string[] firstArray, string[] secondArray)
{
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

SecondArray(firstArray, secondArray);
PrintArray(secondArray);
