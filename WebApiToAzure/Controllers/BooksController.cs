using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiToAzure.Data;
using WebApiToAzure.Repository;
using WebApiToAzure.DTO;


namespace WebApiToAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksController()
        {
            if (BookRepo._Books.Count() == 0)
            {
                AddBooks.AddBookInfo();
            }
            else { return; }
        }

        [HttpGet(Name = "GetAllBooks")]
        public IActionResult GetAll()
        {

            return Ok(BookRepo._Books);
        }

        [HttpPost(Name = "Get By Filter")]
        public IActionResult GetData(RequestModel request)
        {
            var _result = BookRepo._Books;

            if (request == null)
            {
                return BadRequest(new { message = "No data in filter" });
            }
           
            
            if (!string.IsNullOrEmpty(request.Author))
                {
                    _result = _result.Where(x => x.Author.ToUpper() == request.Author.ToUpper());
                }

            if (!string.IsNullOrEmpty(request.Title))
            {
                _result =_result.Where(x => x.Title.ToUpper() == request.Title.ToUpper());
            }

            if (!string.IsNullOrEmpty(request.Genre))
            {
                _result= _result.Where(x => x.Genre.ToUpper() == request.Genre.ToUpper());
            }

            if (_result.Count() == 0)
            {
                return NotFound(new { message = "No result are found!" });
            }
            else
            {
                return Ok(_result);
            }
        }
    }
}