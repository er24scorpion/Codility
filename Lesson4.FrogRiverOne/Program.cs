
Console.WriteLine(Solution.GetSolution(5, new[] { 1, 2, 3, 1, 2, 5, 4, 3 }));

static class Solution
{
    public static int GetSolution(int X, int[] A)
    {
        var time = -1;
        if (!A.Contains(X)) return -1;

        var B = new SortedSet<int>();
        for(var i=0; i< A.Length; i++)
        {
            B.Add(A[i]);
            if (B.Count == X) return i;
        }
        return time;
    }
}