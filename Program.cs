/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
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

double[] InitArray(int dimension )
{
    double[] array = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++) 
    {
        array[i] = rnd.Next();
    }
    return array;
}
// распечатать массив на консоль

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ", "");
    }
    System.Console.WriteLine();
}

double[] array = InitArray(GetNumber("Введите число"));
PrintArray(array);

double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
    if (max < array[i])
    {
        max = array[i];
    }

}
double diff = max - min;
System.Console.WriteLine($"Максимальный элемент массива  = {max}, минимальный элемент массива = {min}, разница между ними составляет =  {diff} ");

























/*
int MinMaxNumbers(int minNum, int maxNum)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        return min;
        if (maxNum < array[i])
        {
            maxNum = array[i];
        }
        return maxNum;
    }
    return minNum;
}
int minNum = MinMaxNumbers(minNum);
int maxNum = MinMaxNumbers(maxNum);
int diff = maxNum - minNum;
//int min = MinMaxNumbers(minNumbers);
//int max = MinMaxNumbers(max);

System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях =  {diff}");
*/
