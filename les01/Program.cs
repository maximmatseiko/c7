// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
Fullarray(numbers);
Console.Write("Вот наш массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"Всего => {numbers.Length} чисел,из них {count} чётные");

void Fullarray(int[] numbers)
{
    for(int a = 0; a < numbers.Length; a++)
    {
        numbers[a] = new Random().Next(-200,2000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int c = 0; c < numbers.Length; c++)
    {
        Console.Write(numbers[c] + ",");
    }
    Console.Write("]");
    Console.WriteLine();
}