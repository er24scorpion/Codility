// See https://aka.ms/new-console-template for more information
static class Solution { 
    public static int[] GetSolution(int[] A, int K)
    {
        if (A.Length == 0 || K < 0) return new int[0];

        int[] B = new int[A.Length];
        if (K > A.Length) K %= A.Length;

        for(int i=0; i<A.Length; i++)
        {
            var newIndex = GetNewIndex(i, A.Length, K);
            B[newIndex] = A[i];
        }
        return B;
    }

    private static int GetNewIndex(int index, int size, int K)
    {
        var newIndex = index + K;
        if (newIndex >= size) newIndex %= size;
        return newIndex;
    }
}