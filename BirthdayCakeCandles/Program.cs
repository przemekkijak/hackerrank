// You are in charge of the cake for a child's birthday. You have decided the cake will have one candle for each year of their total age.
// They will only be able to blow out the tallest of the candles. Count how many candles are tallest

var candles = new List<int>() { 4, 4, 1, 3 };
birthdayCakeCandles(candles);

static int birthdayCakeCandles(List<int> candles)
{
    if (candles.Count == 0)
        return 0;
    
    var max = candles.Max();
    return candles.Count(a => a == max);
}