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
    static void merge(int[] A, int l, int mid, int h)
    {
        int i = l, j = mid + 1, k = l;
        int[] B = new int[100];
        while (i <= mid && j <= h)
        {
            if (A[i] < A[j])
                B[k++] = A[i++];
            else
                B[k++] = A[j++];
        }
        for (; i <= mid; i++)
            B[k++] = A[i];
        for (; j <= h; j++)
            B[k++] = A[j];
        for (i = l; i <= h; i++)
            A[i] = B[i];
    }
    public void IMergeSort(int[] A, int n)
    {
        int p, l, h, mid, i;
        for (p = 2; p <= n; p = p * 2)
        {
            for (i = 0; i + p - 1 < n; i = i + p)
            {
                l = i;
                h = i + p - 1;
                mid = (l + h) / 2;
                merge(A, l, mid, h);
            }
            if (n - i > p / 2)
            {
                l = i;
                h = i + p - 1;
                mid = (l + h) / 2;
                merge(A, l, mid, n - 1);
            }
        }
        if (p / 2 < n)
        {
            merge(A, 0, p / 2 - 1, n - 1);
        }
    }
    public void MergeSort(int[] a, int l, int h)
    {
        int mid;
        if (l < h)
        {
            mid = (l + h) / 2;
            MergeSort(a, l, mid);
            MergeSort(a, mid + 1, h);
            merge(a, l, mid, h);
        }
    }
    static void Swap(ref int x, ref int y)
    {
        (y, x) = (x, y);
    }
}