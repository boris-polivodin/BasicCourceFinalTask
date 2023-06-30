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
    string charString = Prompt("Введите элементы массива, разделяя их пробелом: ");
    Console.WriteLine("Начальный массив: [" + String.Join(", ", charString) + "]");
  }
  
  static string Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine() ?? "Null";
    return readInput;
  }
}