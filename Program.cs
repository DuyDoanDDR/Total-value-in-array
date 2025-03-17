int[] numbers = new int[5] {2,5,9,6,7};
int total = 0;
for (int i = 0; i < numbers.Length; i++)
{
    total = total + numbers[i];
}
Console.WriteLine(total);
