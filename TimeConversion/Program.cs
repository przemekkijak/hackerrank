// Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
//
//   Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
// - 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

var s = "12:45:54PM";
Console.WriteLine(timeConversion(s));

static string timeConversion(string s)
{
    if (string.IsNullOrWhiteSpace(s))
        return "00:00:00";
    
    var suffix = s[^2..];
    var isPm = suffix.ToLower() == "pm";
    var hour = int.Parse(s[..2]);

    if (isPm)
    {
        if (hour != 12)
            return $"{hour + 12}{s.Substring(2, s.Length-4)}";
    }
    else
    {
        if (hour == 12)
            return $"00{s.Substring(2, s.Length-4)}";
    }


    return s.Substring(0, s.Length - 2);
}
