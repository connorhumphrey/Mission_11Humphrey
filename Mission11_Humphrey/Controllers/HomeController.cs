using Microsoft.AspNetCore.Mvc;
using Mission11_Humphrey.Models;
using Mission11_Humphrey.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Humphrey.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;
        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var blah = new BooksListViewModel
            {

                Bookstores = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }

            };
            
            return View(blah);
        }
    }
}
