using Microsoft.EntityFrameworkCore;
using WebApplication1.LibraryManagement;

namespace WebApplication1.Controllers
{
    public class BookBorrowingRepos
    {
        private readonly AuthorDbContext _context;
        private readonly DbSet<BookBorrowing> bookBorrowings;

        public BookBorrowingRepos(AuthorDbContext context, DbSet<BookBorrowing> bookBorrowings)
        {
            _context = context;
            this.bookBorrowings = bookBorrowings;
        }
        public bool Create(BookBorrowing bookBorrowing)
        {
            try
            {
                _context.BookBorrowings.Add(bookBorrowing);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Read(BookBorrowing bookBorrowing)
        {
            try
            {
                var bookBorrowingFind = bookBorrowings.FirstOrDefault(x => x.Id == bookBorrowing.Id);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(BookBorrowing bookBorrowing)
        {
            try
            {
                var bookBorrowingFind = bookBorrowings.FirstOrDefault(x => x.Id == bookBorrowing.Id);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Delete(BookBorrowing bookBorrowing)
        {
            try
            {

                _context.Remove(bookBorrowing);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
