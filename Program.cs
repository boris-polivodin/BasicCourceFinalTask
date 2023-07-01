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
    var size = PromptToNumber("Задайте желаемый размер массива: ");
    string[] stringArr = new string[size];
    FillArray(stringArr);
    Console.WriteLine("Начальный массив: [" + String.Join(", ", stringArr) + "]");
    Console.WriteLine("Результат отбора: [" + String.Join(", ", FindShortStringsInArray(stringArr)) + "]");
  }
  
  static string PromptToString(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine() ?? "Null";
    return readInput;
  }
  static int PromptToNumber(string message) {
      Console.Write(message);
      string readInput = Console.ReadLine() ?? "Null";
      int number;
      bool isNumber = int.TryParse(readInput, out number);
      return number;
  }

  static void FillArray(string[] arr) {
    for (int i = 0; i < arr.Length; i++) {
      arr[i] = PromptToString($"Введите {i+1}-й элемент массива: ");
    }
  }

  static string[] FindShortStringsInArray(string[] arr) {
    return Array.FindAll(arr, element => element.Length <= 3);
  }
}