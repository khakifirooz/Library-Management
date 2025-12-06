namespace Library_Manegment_Domain.Exeptions
{
    public class NotAllowExeption : Exception
    {
        public NotAllowExeption(int value) :base($"امانت بیش از {value} کتاب مجاز نیست")
        {
            
        }
    }

    public class MemberIsInactiveException : Exception
    {
        public MemberIsInactiveException() : base($"امانت کتاب به عضو غیر فعال امکان پذیر نمیباشد!")
        {

        }
    }
}
