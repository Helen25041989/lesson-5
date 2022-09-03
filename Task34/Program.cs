int length = 10;
int[] numbers = new int[length];

for (int i = 0; i < length; i++)
{
    numbers[i] = new Random().Next(100, 999);
}
Console.WriteLine("Сгенерированный массив = [{0}]", string.Join(",", numbers));
int count = 0;

for(int i = 0; i < length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество четных чисел={0}",count);