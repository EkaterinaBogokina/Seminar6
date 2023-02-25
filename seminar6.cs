//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter numbers:");

int[] userNumbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Console.WriteLine($"Numbers greater than zero {PositiveNumbers(userNumbers)}");
        

int PositiveNumbers(int[] array)  
{
  int counter = 0;
  foreach (var i in array)
  {
    if (i > 0)
      counter++;
  }
  return counter;
}

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

  Console.Write("Enter value b1: ");
  double b1 = int.Parse(Console.ReadLine());

  Console.Write("Enter value b2: ");
  double b2 = int.Parse(Console.ReadLine());

  Console.Write("Enter value k1: ");
  double k1 = int.Parse(Console.ReadLine());

  Console.Write("Enter value k2: ");
  double k2 = int.Parse(Console.ReadLine());

  double x = (b2 - b1) / (k1 - k2);
  double y = k2 * x + b2;

  if ((y != k1 * x + b1) || (k1 == k2)) 
  {
    Console.WriteLine("Error");
  }
  else
  {
    Console.WriteLine($"cross point: ({x}); ({y})");
  }

