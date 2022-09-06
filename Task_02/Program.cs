//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
//[3, 7, 23, 12] -> 12
//[4, 6, 8, 1, 4] -> 6

int N = 15;
int[] array = new int [N];
int sum = 0;
for(int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine(array[i]);
}
Console.WriteLine(String.Empty);
for(int i = 1; i < N; i = i + 2)
{
    if(array[i] % 2 == 0)
    {
        sum += array[i];
    }
}
Console.WriteLine("Сумма равна: " + sum);