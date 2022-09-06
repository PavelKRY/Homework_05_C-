// Сгенерировать массив из N целых чисел. Определить, есть ли в нем
// элементы, равные среднему арифметическому среди всех элементов. Вывести
// на экран ответ: «Да» или «Нет»
int N = 10;
int [] array = new int [N];
int sum = 0;
int count = 0;
for (int i = 0; i < N; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine(array[i]);
}
Console.WriteLine(string.Empty);
for (int i = 0; i < N; i++)
{
    sum += array[i];
}
int midSum = sum/N;
for (int i = 0; i < N; i++)
{
    if(array[i] == midSum)
    {
        count++;
        Console.WriteLine("Да");
        break;
    }
}
if (count == 0)
{
    Console.WriteLine("Нет");
}