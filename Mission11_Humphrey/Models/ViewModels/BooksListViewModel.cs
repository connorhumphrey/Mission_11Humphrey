namespace Mission11_Humphrey.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Bookstore> Bookstores { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();

    }
}
