// С клавиатуры вводится натуральное число N (N>100). Выяснить,
// сколько простых чисел находится в диапазоне от 1 до N.

Console.WriteLine("Введите трёхзначное число для проверки: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 99 && number < 1000)
{
    int[] array = new int[number];
    array[0] = 1;
    int count = 0;
    //Console.WriteLine(array[0]);
    for(int i = 1; i < number; i++)
        {
        array[i] = array[i-1]+1;
        //Console.WriteLine(array[i] + "+");
        }
    for(int i = 1;i < number;i++)
    {
        for(int j = 1; j< i; j++)
        {
            if(array[i]%array[j]!=0)
            {
                count++;
                
            }
             
        }
    }
    Console.WriteLine("Простых чисел встречается " + count);

}
else
    {
    Console.WriteLine("Вы ввели не трёхзначное число, пожалуйста введите трёхзначное");
    }
