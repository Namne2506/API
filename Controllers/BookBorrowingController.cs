using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.LibraryManagement;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookBorrowingController : ControllerBase
    {
        private readonly BookBorrowingRepos repos;

        public BookBorrowingController(BookBorrowingRepos repos)
        {
            this.repos = repos;
        }
        [HttpGet]
        public IActionResult Get(BookBorrowing bookBorrowing)
        {
            try
            {
                var data = repos.Read(bookBorrowing);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post(BookBorrowing bookBorrowing)
        {
            try
            {
                var data = repos.Create(bookBorrowing);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(BookBorrowing bookBorrowing)
        {
            try
            {
                var data = repos.Delete(bookBorrowing);
                return StatusCode(204, data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
        [HttpPut]
        public IActionResult Put(BookBorrowing bookBorrowing)
        {
            try
            {
                var data = repos.Update(bookBorrowing);
                return StatusCode(404, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
