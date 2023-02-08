using Microsoft.AspNetCore.Mvc;
using Services.Dtos;
using Services.Interfaces;

namespace Books.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var books = await _bookService.Get();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(BookDto bookDto)
        {
            try
            {
                var booCreated = await _bookService.Post(bookDto);
                return Ok(booCreated);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var book = await _bookService.GetById(Id);
                return Ok(book);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(int Id, BookDto bookDto)
        {
            try
            {
                var book = await _bookService.Update(bookDto);
                return Ok(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var bookDeleted = await _bookService.Delete(Id);
                return Ok(bookDeleted);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
    }
}
