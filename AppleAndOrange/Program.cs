
//Apple Tree
var a = 4;

//Orange tree
var b = 12;

var houseA = 7;
var houseB = 10;

var apples = new List<int>() { 2, 3, -4 };
var oranges = new List<int>() { 3, -2, -4 };

countApplesAndOranges(houseA, houseB, a, b, apples, oranges);

static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
{
    var appleCount = apples.Count(appleDistance => a + appleDistance >= s && a + appleDistance <= t);
    var orangeCount = oranges.Count(orangeDistance => b + orangeDistance <= t && b + orangeDistance >= s);

    Console.WriteLine(appleCount);
    Console.WriteLine(orangeCount);
}