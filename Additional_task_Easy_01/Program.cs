// Сгенерировать массив из N целых чисел от 1 до 100.. Выведите на экран
//элементы, кратные трём и пяти, но не кратные семи.

int N = 100;
int[] array = new int [N];
array[0] = 1;
Console.WriteLine(array[0]);
for(int i = 1; i < N; i++)
{
    array[i] = array[i-1]+1;
    Console.WriteLine(array[i]);
}
Console.WriteLine(string.Empty);
for(int i = 1; i < N; i++)
{
    if(array[i] % 3 == 0 && array[i] % 5 == 0 && array[i] % 7 > 0)
    {
        Console.WriteLine(array[i]);
    }
}