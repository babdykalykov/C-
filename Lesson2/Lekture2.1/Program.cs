int n = 10;
int[] arr = new int[10];
int i = 0;
while (i < n)
// while (i < arr.Length)
{
    arr[i] = i + 1;
    // Console.Write(arr[i]);
    // Console.Write(' ');
    Console.Write($"{arr[i]} ");
    i = i + 1;
}