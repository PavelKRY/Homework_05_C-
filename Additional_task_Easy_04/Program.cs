// Сгенерировать массив из N целых чисел от 1 до 100. Вычислить
// величину
// 𝐴
// 𝐺
// , где A – среднее арифметическое среди всех элементов массива, а
// G – среднее геометрическое.

int N = 100;
int[] array = new int [N];
int sum = 0;
int work = 0;
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
    sum += array[i];
    work *= array[i];
}
double midSum = sum/N;
double midWork = Math.Pow((double) work, (double) N);
Console.WriteLine(midSum/midWork);