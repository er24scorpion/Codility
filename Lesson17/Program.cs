// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(Solution.Get(new[] { 1, 5, 2, -2 }));

static class Solution
{

    public static int Get(int[] A)
    {
        var sum = 0;

        //var sum1 = A.Select(x=> Math.Abs(x)).Sum();
        //var sum2 = A.Select(x => Math.Abs(x)*(-1)).Sum();


        return System.Math.Abs(sum);


    }

}