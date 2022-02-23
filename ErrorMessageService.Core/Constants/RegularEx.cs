using System.Text.RegularExpressions;

namespace Core.Constants.RegularEx;

public static class RegularEx
{
    public static bool IsNumeric(int num)
    {
        string a = num.ToString();
        var regex = new Regex(@"^[0-9]+$");
        return regex.IsMatch(a);
    }

    public static bool IsString(string chr)
    {
        var regex = new Regex(@"^[A-Za-z\s]+$");
        return regex.IsMatch(chr);
    }
}
