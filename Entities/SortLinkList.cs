class SortLinkList
{
    void initializeBins(Node[] p, int n)
    {
        for (int i = 0; i < n; i++)
        {
            p[i] = null;
        }
    }

    void Insert(Node[] ptrBins, int value, int idx)
    {
        Node temp = new()
        {
            val = value,
            next = null
        };

        if (ptrBins[idx] == null)
        {
            ptrBins[idx] = temp;  // ptrBins[idx] is head ptr
        }
        else
        {
            Node p = ptrBins[idx];
            while (p.next != null)
            {
                p = p.next;
            }
            p.next = temp;
        }
    }

    public int Delete(Node[] ptrBins, int idx)
    {
        Node p = ptrBins[idx];  // ptrBins[idx] is head ptr
        ptrBins[idx] = ptrBins[idx].next;
        int x = p.val;
        return x;
    }

    public int getBinIndex(int x, int idx)
    {
        return (int)(x / pow(10, idx)) % 10;
    }

    int Max(int[] A, int n)
    {
        int max = -32768;
        for (int i = 0; i < n; i++)
        {
            if (A[i] > max)
            {
                max = A[i];
            }
        }
        return max;
    }

    int countDigits(int x)
    {
        int count = 0;
        while (x != 0)
        {
            x = x / 10;
            count++;
        }
        return count;
    }
    public void RadixSort(int[] A, int n)
    {
        int max = Max(A, n), i;
        int nPass = countDigits(max);

        // Create bins array
        Node[] bins = new Node[10];

        // Initialize bins array with null
        initializeBins(bins, 10);

        // Update bins and A for nPass times
        for (int pass = 0; pass < nPass; pass++)
        {

            // Update bins based on A values
            for (i = 0; i < n; i++)
            {
                int binIdx = getBinIndex(A[i], pass);
                Insert(bins, A[i], binIdx);
            }

            // Update A with sorted elements from bin
            i = 0;
            int j = 0;
            while (i < 10)
            {
                while (bins[i] != null)
                {
                    A[j++] = Delete(bins, i);
                }
                i++;
            }
            // Initialize bins with null again
            initializeBins(bins, 10);
        }
    }
}