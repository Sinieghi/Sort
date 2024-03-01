class Program
{
    static void Main(string[] args)
    {
        Sort sort = new();
        int[] a = [7, 24, 8, 3, 19, 10, 1, 5
        // , int.MaxValue
        ];
        // a = sort.Bubble(a, a.Length);
        // a = sort.Insertion(a, a.Length);
        // a = sort.SelectionSort(a, a.Length);
        // sort.QuickSort(ref a, 0, a.Length - 1);
        // sort.IMergeSort(a, a.Length - 1);
        // sort.MergeSort(a, 0, a.Length - 1);
        // sort.CountSort(a, a.Length );
        sort.ShellSort(a, a.Length);

        for (int i = 0; i < a.Length; i++)
        {
            System.Console.WriteLine(a[i]);
        }
    }
}