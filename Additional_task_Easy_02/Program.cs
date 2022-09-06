// Сгенерировать массив из N целых чисел от -100 до 100. Выведите на
// экран количество положительных чисел и их сумму.
int N = 201;
int[] array = new int [N];
array[0] = -100;
Console.WriteLine(array[0]);
int count_positive = 0;
int sum_positive = 0;
for(int i = 1; i < N; i++)
{
    array[i] = array[i-1]+1;
    Console.WriteLine(array[i]);
}
Console.WriteLine(string.Empty);
for(int i = 1; i < N; i++)
{
    if(array[i] > 0)
    {
        count_positive++;
        sum_positive += array[i];
    }
}
Console.WriteLine("Количество положительных чисел = " + count_positive);
Console.WriteLine("Сумма положительных чисел = " + sum_positive);