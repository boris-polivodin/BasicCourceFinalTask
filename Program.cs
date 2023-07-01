/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк
, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
class Program {
  public static void Main(string[] args) {
    string charString = Prompt("Введите элементы массива, разделяя их пробелом  и заключая в кавычки: ");
    var stringArr = ConvertStringToStringArray(charString);
    Console.WriteLine("Начальный массив: [" + String.Join(", ", stringArr) + "]");
    Console.WriteLine("Результат отбора: [" + String.Join(", ", FindShortStringsInArray(stringArr)) + "]");
  }
  
  static string Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine() ?? "Null";
    return readInput;
  }

  static string[] ConvertStringToStringArray(string text) {
    var stringArray = text.Split("\" \"", StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < stringArray.Length; i++) {
      stringArray[i] = "\"" + stringArray[i].Replace("\"", "") + "\"";
    }
    return stringArray;
  }
  
  static string[] FindShortStringsInArray(string[] arr) {
    for (int i = 0; i < arr.Length; i++) {
      arr[i] = arr[i].Replace("\"", "");
    }
    var selectArr = Array.FindAll(arr, element => element.Length <= 3);
    for (int i = 0; i < selectArr.Length; i++) {
      selectArr[i] = "\"" + selectArr[i] + "\"";
    }
    return selectArr;
  }
}