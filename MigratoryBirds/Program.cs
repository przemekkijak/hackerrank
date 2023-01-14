
var arr = new int[] { 1,4,4,4,5,3 };

Console.WriteLine(migratoryBirds(arr.ToList()));

static int migratoryBirds(List<int> arr)
{
    if (arr.Count == 0)
        return 0;

    var dict = new Dictionary<int, int>();
    
    foreach (var a in arr)
    {
        if (dict.ContainsKey(a))
        {
            dict[a] += 1;
        }
        else
        {
            dict.Add(a, 1);
        }
    }

    var maxCount = dict.MaxBy(a => a.Value).Value;
    var matchingElements = dict.Where(a => a.Value == maxCount).ToList();
    return matchingElements.Count == 1
        ? matchingElements.First().Key
        : matchingElements.MinBy(a => a.Key).Key;
}