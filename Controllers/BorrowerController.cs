using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.LibraryManagement;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : ControllerBase
    {
        private readonly BorrowerRepos repos;

        public BorrowerController(BorrowerRepos repos)
        {
            this.repos = repos;
        }
        [HttpGet]
        public IActionResult Get(Borrower borrower)
        {
            try
            {
                var data = repos.Read(borrower);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Post(Borrower borrower)
        {
            try
            {
                var data = repos.Create(borrower);
                return StatusCode(201, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(Borrower borrower)
        {
            try
            {
                var data = repos.Delete(borrower);
                return StatusCode(204, data);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }
        [HttpPut]
        public IActionResult Put(Borrower borrower)
        {
            try
            {
                var data = repos.Update(borrower);
                return StatusCode(404, data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
