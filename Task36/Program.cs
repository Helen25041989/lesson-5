int length = 10;
int[] numbers = new int[length];

for (int i = 0; i < length; i++)
{
    numbers[i] = new Random().Next(-100,100);
}
Console.WriteLine("Сгенерированный массив = [{0}]", string.Join(",", numbers));

int summ = 0;
for (int i = 0; i < length; i=i+2)
{
    summ +=numbers[i];
}
Console.WriteLine("Сумма чисел на нечетных позициях = {0}", summ);