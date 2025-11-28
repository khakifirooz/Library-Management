namespace Library_Manegment_Domain.Common
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        //public DateTime CreationDate { get; set; }
        //public DateTime LastModifiedDate { get; set; }
    }
}
