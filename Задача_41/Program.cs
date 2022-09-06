// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

Console.Write("Введите кол-во чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
}
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++; 
}
Console.WriteLine($"Кол-во чисел больше нуля = {count}");


