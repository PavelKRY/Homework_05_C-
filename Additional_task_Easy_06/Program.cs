// С клавиатуры вводится натуральное число N. Выяснить, является ли оно
// простым

Console.WriteLine("Введите число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
array[0] = 1;
int count = 0;
//Console.WriteLine(array[0]);
for(int i = 1; i < number; i++)
{
    array[i] = array[i-1]+1;
    //Console.WriteLine(array[i] + "+");
}

for(int i =1;i<number-1;i++)
{
    if(number%array[i]==0)
    {
        count++;
    }
}
if(count == 0)
{
    Console.WriteLine("Является простым числом");
}
else
{
    Console.WriteLine("Не является простым числом");
}