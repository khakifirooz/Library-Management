using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace LibraryManagementWindowsForm;

internal static class UiActions
{
    private sealed class State { public bool Busy; }
    private static readonly ConditionalWeakTable<Form, State> States = new();
    public static async Task RunAsync(Form form, Func<Task> action, string operation = "عملیات")
    {
        var state = States.GetOrCreateValue(form);
        if (state.Busy || form.IsDisposed) return;
        state.Busy = true;
        form.Enabled = false;
        form.UseWaitCursor = true;
        try { await action(); }
        catch (Exception error)
        {
            Debug.WriteLine($"[{operation}] {error}");
            Trace.TraceError("{0}: {1}", operation, error);
            MessageBox.Show(error is FormatException or UnauthorizedAccessException
                ? error.Message : $"{operation} انجام نشد. اتصال و نسخهٔ دیتابیس را بررسی کنید.",
                "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            state.Busy = false;
            if (!form.IsDisposed) { form.Enabled = true; form.UseWaitCursor = false; }
        }
    }
}
