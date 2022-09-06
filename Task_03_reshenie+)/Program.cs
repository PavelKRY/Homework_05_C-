// Задайте массив натуральных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int N = 100;
int[] array = new int [N];
array[0] = 1;
Console.WriteLine(array[0]);
for(int i = 1; i < N; i++)
{
    array[i] = array[i-1]+1;
    Console.WriteLine(array[i]);
}
int answer = array[N-1] - array[0];
Console.WriteLine(answer);