
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using WebApplication1.LibraryManagement;

namespace WebApplication1.Controllers
{
    public class Authorrepos 
    {
        private readonly AuthorDbContext _context;
        private readonly DbSet<Author> _authors;

        public Authorrepos(AuthorDbContext context, DbSet<Author> authors)
        {
            _context = context;
            _authors = authors;
        }
        public bool Create(Author author)
        {
            try
            {
                _authors.Add(author);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
        public bool Read(Author author)
        {
            try 
            {
                var authorFind = _authors.FirstOrDefault(x => x.AuthorId == author.AuthorId);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Author author)
        {
            try
            {
                var authorFind = _authors.FirstOrDefault(x => x.AuthorId == author.AuthorId);
                _context.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
            
        }
        public bool Delete(Author author)
        {
            try
            {
                _authors.Remove(author);
                _context.SaveChanges();
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }
       
    }
}
