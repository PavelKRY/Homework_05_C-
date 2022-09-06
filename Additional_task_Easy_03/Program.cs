// Сгенерировать массив из N целых чисел от -100 до 100. Выясните,
// содержатся ли в массиве отрицательные числа. На экран вывести только ответ:
// «Да» или «Нет».

int N = 201;
int[] array = new int [N];
array[0] = -100;
Console.WriteLine(array[0]);
for(int i = 1; i < N; i++)
{
    array[i] = array[i-1]+1;
    Console.WriteLine(array[i]);
}
for(int i = 0; i < N; i++)
{
    if (array[i] < 0)
    {
    Console.WriteLine("yes");
    break;
    }
}