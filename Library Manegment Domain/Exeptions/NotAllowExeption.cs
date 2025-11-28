namespace Library_Manegment_Domain.Exeptions
{
    public class NotAllowExeption : Exception
    {
        public NotAllowExeption(int value) :base($"امانت بیش از {value} کتاب مجاز نیست")
        {
            
        }
    }
}
