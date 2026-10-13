using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Library_Manegment_Domain.Common;
using Library_Manegment_Domain.Entities.Loans;

namespace Library_Manegment_Domain.Entities.Books;

public class Book : BaseEntity<int>
{
    public string Title { get; private set; } = "";
    public string Author { get; private set; } = "";
    public string Language { get; private set; } = "";
    public byte[] Image { get; private set; } = Array.Empty<byte>();
    public bool IsDeleted { get; private set; }
    public bool IsLoaned { get; private set; }
    public List<Loan> Loans { get; private set; } = new();

    // EF can materialize existing records without invoking creation rules.
    private Book() { }

    public Book(string title, string author, string language, byte[] image)
    {
        SetMetadata(title, author, language, image);
    }

    public void Update(string title, string author, string language, byte[] image)
    {
        if (IsDeleted) throw new InvalidOperationException("کتاب حذف‌شده قابل ویرایش نیست.");
        SetMetadata(title, author, language, image);
    }

    private void SetMetadata(string title, string author, string language, byte[]? image)
    {
        // Validate all fields before changing any tracked property.
        var validTitle = RequiredText(title, "عنوان کتاب");
        var validAuthor = RequiredText(author, "نویسنده");
        var validLanguage = RequiredText(language, "زبان");
        Title = validTitle; Author = validAuthor; Language = validLanguage;
        Image = image ?? Array.Empty<byte>();
    }

    public static string RequiredText(string? text, string caption)
    {
        var value = (text ?? "").Trim();
        var hasContent = value.Any(c => !char.IsWhiteSpace(c)
            && char.GetUnicodeCategory(c) is not UnicodeCategory.Format and not UnicodeCategory.Control);
        if (!hasContent) throw new ArgumentException($"{caption} را وارد کنید.");
        if (value.Length > 50) throw new ArgumentException($"{caption} نباید بیشتر از ۵۰ کاراکتر باشد.");
        return value;
    }

    public void Delete()
    {
        if (IsLoaned) throw new InvalidOperationException("ابتدا کتاب امانت‌داده‌شده را پس بگیرید.");
        IsDeleted = true;
    }

    public void Loaned()
    {
        if (IsDeleted) throw new InvalidOperationException("کتاب حذف‌شده قابل امانت نیست.");
        if (IsLoaned) throw new InvalidOperationException("این کتاب در حال حاضر امانت است.");
        IsLoaned = true;
    }

    public void LoanedBack() => IsLoaned = false;
}
