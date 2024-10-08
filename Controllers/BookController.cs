using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.LibraryManagement;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookRepos repos;

        public BookController(BookRepos repos)
        {
            this.repos = repos;
        }

        [HttpGet]
        public IActionResult Get(Book book)
        {
            try
            {
                var data = repos.Read(book);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post(Book book)
        {
            try
            {
                var data = repos.Create(book);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(Book book)
        {
            try
            {
                var data = repos.Delete(book);
                return StatusCode(204, data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
        [HttpPut]
        public IActionResult Put(Book book)
        {
            try
            {
                var data = repos.Update(book);
                return StatusCode(404, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }

}
