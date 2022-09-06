// Задайте массив натуральных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int N = 100;
int[] array = new int [N];
for(int i = 0;i < N;i++)
{
    array[i] = new Random().Next(1,101);
    Console.WriteLine(array[i]);
}
Console.WriteLine(String.Empty);
int min = array[0];
int max = array[0];
for(int i = 0;i < N;i++)
{
    if(array[i]<min)
    {
        min = array[i];
    }
    if(array[i]>max)
    {
        max = array[i];
    }
}
Console.WriteLine(max-min);