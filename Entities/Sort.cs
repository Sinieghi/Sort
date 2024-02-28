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
    public int[] Insertion(int[] a, int n)
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
    public int[] SelectionSort(int[] a, int n)
    {
        int i, j, k;
        for (i = 0; i < n - 1; i++)
        {
            for (j = k = i; j < n; j++)
            {
                if (a[j] < a[k])
                {
                    k = j;
                }
                Swap(ref a[i], ref a[k]);
            }
        }
        return a;
    }
    //quick sort
    public int Partition(int[] a, int l, int h)
    {
        int pivot = a[l];
        int i = l, j = h;
        do
        {
            do { i++; } while (a[i] <= pivot);
            do { j--; } while (a[j] > pivot);
            if (i < j) Swap(ref a[i], ref a[j]);
        } while (i < j);
        Swap(ref a[l], ref a[j]);
        return j;
    }
    //quicksort recursive
    public void QuickSort(ref int[] a, int l, int h)
    {
        //make sure to not use quicksort in ordered list ascended or descending
        //worst case ordered list O(n²), when partitioning start from last or first element 
        //best case O(nlogn), when partitioning start from middle element
        int j;
        if (l < h)
        {
            j = Partition(a, l, h);
            QuickSort(ref a, l, j);
            QuickSort(ref a, j + 1, h);
        }
    }
    //end of quicksort

    static void Swap(ref int x, ref int y)
    {
        (y, x) = (x, y);
    }
}