
Console.WriteLine(Solution.GetSolution(new[] {5, 1, 2, 3} ));

static class Solution
{
    public static int GetSolution(int[] A)
    {
        Array.Sort(A);
        var B = Enumerable.Range(1, A.Length+1);


        return B.Except(A).FirstOrDefault();
    }
}