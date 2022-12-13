/*
Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// Получить размерность массива с консоли

int GetNumber(string message)
{
    int result;

    while (true)
    {
        System.Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else 
        {
            System.Console.WriteLine("Ввели не число, введите корректное число: ");
        }
    }
    return result;
}  

// Получить заполненный массив рандомными числами

int[] InitArray(int dimension )
{
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}
// распечатать массив на консоль

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ", "");
    }
    System.Console.WriteLine();
}

int[] array = InitArray(GetNumber("Введите число"));
PrintArray(array);

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    
    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }

}
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях =  {sum}");