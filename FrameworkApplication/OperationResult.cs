namespace FrameworkApplication
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public OperationResult()
        {
            Success = false;
        }

        public OperationResult Succeded(string message = "عملیات با موفقیت انجام شد.")
        {
            Success = true;
            Message = message;
            return this;
        }
        public OperationResult Failed(string message = "لطفا دوباره تلاش کنید")
        {
            Success = false;
            Message = message;
            return this;
        }

    }
}
