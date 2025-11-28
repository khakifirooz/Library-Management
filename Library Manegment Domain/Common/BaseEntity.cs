namespace Library_Manegment_Domain.Common
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        //public DateTime CreationDate { get; set; }
        //public DateTime LastModifiedDate { get; set; }
    }
}
