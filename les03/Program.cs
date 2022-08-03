// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите размер массива :");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
ourarray(numbers);
Console.Write("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
        {
            min = numbers[a];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void ourarray (double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(-100,1000)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ; ");
        }
    Console.Write("]");
    Console.WriteLine();
}
