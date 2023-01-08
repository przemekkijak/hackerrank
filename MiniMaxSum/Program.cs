// Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers.
// Then print the respective minimum and maximum values as a single line of two space-separated long integers.

var arr = new int[] {256741038, 623958417, 467905213, 714532089, 938071625};
miniMaxSum(arr.ToList());

static void miniMaxSum(List<int> arr)
{
    if (arr.Count == 0)
    {
        Console.WriteLine("0 0");
        return;
    }

    var sortedArray = arr.Select(a => (long)a).ToArray();
    for (var i = 0; i < sortedArray.Length-1; i++)
    {
        for (var y = i + 1; y < sortedArray.Length; y++)
        {
            if (sortedArray[y] < sortedArray[i])
            {
                (sortedArray[y], sortedArray[i]) = (sortedArray[i], sortedArray[y]);
            }
        }
    }

    long minimum = 0;
    for (var i = 0; i < sortedArray.Length - 1; i++)
    {
        minimum += sortedArray[i];
    }

    long maximum = 0;
    for (var i = sortedArray.Length - 1; i > 0; i--)
    {
        maximum += sortedArray[i];
    }
    
    Console.WriteLine($"{minimum} {maximum}");
}