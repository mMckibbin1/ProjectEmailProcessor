using System.Globalization;

namespace ProjectHoursEmailProcessor.Extensions;

public static class StringExtensions
{
    public static string ToCapitaliseEachWord(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return input;

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.ToLower());
    }
}

