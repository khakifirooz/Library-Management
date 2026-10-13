using System.Globalization;
using FrameworkApplication;

namespace LibraryManagementWindowsForm;

internal static class UiText
{
    public static string Digits(object? value)
    {
        var text = Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
        return string.Concat(text.Select(c => c is >= '0' and <= '9' ? (char)('\u06f0' + c - '0') : c));
    }

    public static string Date(DateTime? value) => value is null ? "—" : Digits(PersianDateHelper.ToPersian(value.Value));
    public static string SearchKey(string? text) => PersianDateHelper.NormalizeDigits(text)
        .Replace('ي', 'ی').Replace('ك', 'ک').Trim();
    public static string Role(string? role) => role switch
    {
        "SuperAdmin" => "مدیر ارشد",
        "Admin" => "مدیر",
        "Member" => "عضو",
        "User" => "کاربر",
        _ => "نقش تعریف‌نشده"
    };
}
