// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 100);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int NumberEvenNumbers(int[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 ==0) k++;
    return k;
}
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt16(Console.ReadLine());

int[] numbers = new int[n];

FillArray(numbers);
PrintArray(numbers);

Console.WriteLine($"Количество четных элементов массива равно {NumberEvenNumbers(numbers)}");