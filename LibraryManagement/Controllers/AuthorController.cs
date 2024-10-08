using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.LibraryManagement;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly Authorrepos repos;

        public AuthorController(Authorrepos authorrepos)
        {
            repos = authorrepos;
        }

        [HttpGet]
        public IActionResult Get(Author author)
        {
            try
            {
                var data = repos.Read(author);
                return Ok(data);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 


        [HttpPost]
        public IActionResult Post(Author author)
        {
            try
            {
                var data = repos.Create(author);
                return StatusCode(201, data);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(Author author)
        {
            try
            {
                var data = repos.Delete(author);
                return StatusCode(204, data);

            }catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
        [HttpPut]
        public IActionResult Put(Author author)
        {
            try
            {
                var data = repos.Update(author);
                return StatusCode(404, data);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
