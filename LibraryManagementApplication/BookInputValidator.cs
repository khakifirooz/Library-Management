using System;
using Library_Manegment_Domain.Entities.Books;
using LibraryManagementContracts.Book;

namespace LibraryManagementApplication;

internal static class BookInputValidator
{
    public static string? Prepare(BookDTO? command)
    {
        if (command is null) return "اطلاعات کتاب ارسال نشده است.";
        try
        {
            var title = Book.RequiredText(command.Title, "عنوان کتاب");
            var author = Book.RequiredText(command.Author, "نویسنده");
            var language = Book.RequiredText(command.Language, "زبان");
            command.Title = title; command.Author = author; command.Language = language;
            command.Image ??= Array.Empty<byte>();
            return null;
        }
        catch (ArgumentException error) { return error.Message; }
    }
}
