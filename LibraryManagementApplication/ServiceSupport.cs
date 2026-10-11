using System.Diagnostics;
using FrameworkApplication;
using Library_Manegment_Domain.Common;

namespace LibraryManagementApplication;

internal static class ServiceSupport
{
    public static OperationResult Failure(
        IUnitOfWork work,
        Exception error)
    {
        work.ResetTracking();

        Trace.TraceError(
            "Library operation failed: {0}",
            error.GetType().Name);

        return new OperationResult().Failed(
            error is ArgumentException
                or InvalidOperationException
                or Library_Manegment_Domain.Exeptions.NotAllowExeption
                or Library_Manegment_Domain.Exeptions.MemberIsInactiveException
                ? error.Message
                : "ثبت اطلاعات انجام نشد؛ اتصال، وضعیت دیتابیس یا تداخل همزمان را بررسی کنید.");
    }
}