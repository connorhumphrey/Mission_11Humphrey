namespace Mission11_Humphrey.Models
{
    public interface IBookstoreRepository
    {
        public IQueryable<Bookstore> Books { get; }
    }
}
