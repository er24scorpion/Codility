// See https://aka.ms/new-console-template for more information



// Find unpaired element
Console.WriteLine($"Get {Solution.GetSolution(new[] { 9, 3, 9, 3, 9, 7, 9 })}");

static class Solution
{
    public static int GetSolution(int[] A)
    {
        var dictionary = new Dictionary<int, int>();

        foreach (var i in A)
        {
            if (dictionary.ContainsKey(i))
            {
                dictionary[i] += 1;
            }
            else
            {
                dictionary[i] = 1;
            }
        }

        var res = dictionary.Values.FirstOrDefault(x => x % 2 != 0);
        return dictionary.FirstOrDefault(x => x.Value == res).Key;
    }

}