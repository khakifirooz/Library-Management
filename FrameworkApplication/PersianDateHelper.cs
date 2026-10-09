using System.Globalization;

namespace FrameworkApplication;

public static class PersianDateHelper
{
    public static string NormalizeDigits(string? text) =>
        string.Concat((text ?? "").Select(c => c switch
        {
            >= '\u06f0' and <= '\u06f9' =>
                (char)('0' + c - '\u06f0'),

            >= '\u0660' and <= '\u0669' =>
                (char)('0' + c - '\u0660'),

            _ => c
        }));

    public static string ToPersian(DateTime date)
    {
        var calendar = new PersianCalendar();

        if (date < calendar.MinSupportedDateTime ||
            date > calendar.MaxSupportedDateTime)
        {
            return "تاریخ نامعتبر";
        }

        return FormattableString.Invariant(
            $"{calendar.GetYear(date):0000}/{calendar.GetMonth(date):00}/{calendar.GetDayOfMonth(date):00}");
    }

    public static string ToPersian(DateTime? date) =>
        date.HasValue ? ToPersian(date.Value) : "";

    public static bool TryParse(string? text, out DateTime date)
    {
        date = default;

        var input = NormalizeDigits(text).Trim();

        if (input.Length != 10 ||
            input[4] != '/' ||
            input[7] != '/')
        {
            return false;
        }

        if (!input.Where((_, i) => i != 4 && i != 7)
                  .All(c => c is >= '0' and <= '9'))
        {
            return false;
        }

        if (!int.TryParse(input[..4], out var year) ||
            !int.TryParse(input[5..7], out var month) ||
            !int.TryParse(input[8..], out var day))
        {
            return false;
        }

        try
        {
            date = new PersianCalendar()
                .ToDateTime(year, month, day, 0, 0, 0, 0);

            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }
    }

    public static DateTime Parse(string text) =>
        TryParse(text, out var date)
            ? date
            : throw new FormatException(
                "تاریخ شمسی را با قالب 1405/07/15 وارد کنید.");
}