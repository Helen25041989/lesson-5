int length = 10;
double[] numbers = new double[length];

for (int i = 0; i < length; i++)
{
    numbers[i] = Math.Round(new Random().NextDouble() * 100,3);
}
Console.WriteLine("Сгенерированный массив = [{0}]", string.Join("; ", numbers));

Console.WriteLine("Разница между максимальным {0} и минимальным {1} = {2}",
    numbers.Max(), numbers.Min(), Math.Round(numbers.Max()-numbers.Min(),3));
