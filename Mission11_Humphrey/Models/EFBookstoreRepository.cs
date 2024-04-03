
namespace Mission11_Humphrey.Models
{
    public class EFBookstoreRepository : IBookstoreRepository 
    {
        private BookstoreContext _context;
        public EFBookstoreRepository(BookstoreContext temp) 
        { 
            _context = temp;
        }

        public IQueryable<Bookstore> Books => _context.Books;
    }
}

