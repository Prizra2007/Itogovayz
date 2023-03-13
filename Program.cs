// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

string[] array = {"Hello", "2", "world", "try", "console", "ask", "computer", "123"};
Console.WriteLine ($"Дан массив: {GetArrayAsString(array)}");

string[] threeCharsArray = GetNewArray (array);
if (threeCharsArray.Length !=0) Console.WriteLine ($"Новый массив: {GetArrayAsString(threeCharsArray)}");
    else Console.WriteLine ($"Нет слов в массиве, удовлетворяющих условию");

string GetArrayAsString (string [] array) //вывод массива в строку
{
    string s = string.Empty;
    foreach (var item in array) s+=$"{item} ";
 return s;
}    

string[] GetNewArray (string[] arr)
{
    int kol=0;
    string[] newArray = Array.Empty<string>();
    string[] tempArray;

    for (int i=0;i<arr.Length;i++) 
    {
        if (arr[i].Length<4)
        {
            kol++;
            tempArray = newArray;
            newArray = new string[kol];
            for (int j=0;j<tempArray.Length; j++) newArray[j] = tempArray[j];
            newArray[kol - 1] = arr[i];
         }
    }

return newArray;
}



