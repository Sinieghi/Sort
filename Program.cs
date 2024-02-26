class Program
{
    static void Main(string[] args)
    {
        Sort sort = new();
        int[] a = [7, 8, 3, 19, 10, 1, 5];
        a = sort.Bubble(a, a.Length);
        for (int i = 0; i < a.Length; i++)
        {
            System.Console.WriteLine(a[i]);
        }
    }
}