class Sort
{
    public int[] Bubble(int[] a, int n)
    {
        int i, j;
        for (i = 0; i < n - 1; i++)
        {
            int flag = 0;
            for (j = 0; j < n - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    flag = 1;
                    Swap(ref a[j], ref a[j + 1]);
                }
            }
            if (flag == 0) break;
        }
        return a;
    }
    public int[] InsertSort(int[] a, int n)
    {
        int i, j, x;
        for (i = 1; i < n; i++)
        {
            j = i - 1;
            x = a[i];
            while (j > -1 && a[j] > x)
            {
                a[j + 1] = a[j];
                j--;
            }
            a[j + 1] = x;
        }
        return a;
    }
    static void Swap(ref int x, ref int y)
    {
        (y, x) = (x, y);
    }
}