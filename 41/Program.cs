// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.Write($"Введи число М (количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[m];

void Array(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int result(int[] massive)
{
  int count = 0;
  for (int i = 0; i < massive.Length; i++)
  {
    if(massive[i] > 0 ) count += 1; 
  }
  return count;
}
Array(m);
Console.WriteLine($"Введено чисел больше 0: {result(massive)} ");