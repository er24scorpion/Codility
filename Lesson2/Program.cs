
var test = new[] {

        new[] { 3, 8, 9, 7, 6 },
        new[]  { 1,2,3,4 },
};

var Ks = new[] { 1, 2, 3, 4, 5, 6, 7, 8 , 9, 10 };
foreach (var item in test)
{
    foreach(var k in Ks)
    {
        Console.WriteLine($"Array: [{string.Join(",", item)}], K: {k}");
        Console.WriteLine($"Result: [{string.Join(",", Solution.GetSolution(item, k))}]");
    }
}