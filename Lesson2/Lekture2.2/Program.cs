// int n = 10;
int[] arr = { 2, 3, 4, 5, 7, 6, 5, 4, 5, 6 };
int i = 0;

//while (i < n)
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}