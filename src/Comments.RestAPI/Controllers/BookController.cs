using Microsoft.AspNetCore.Mvc;
using SusilEdizioni.Core.Exceptions;
using SusilEdizioni.Core;
using SusilEdizioni.RestAPI.Mapper;
using SusilEdizioni.RestAPI.Model;

namespace SusilEdizioni.RestAPI.Controllers
{
    [ApiController]
    [Route("Book")]
    public class BookController : ControllerBase
    {
        private ApplicationManagerBooks _managerBook;

        public BookController(ApplicationManagerBooks managerBook)
        {
            _managerBook = managerBook;
        }

        [HttpGet("Get_All_Books")]
        public ActionResult<List<BookDto>> GetAllBook() =>
            Ok(_managerBook.GetAllBooks().Select(s => BookDtoMapper.From(s)).ToList());

        [HttpGet("Get_Book_By_Id" + "{id:int}")]
        public ActionResult<BookDto> GetBookById(int id)
        {
            try
            {
                var book = _managerBook.GetBook(id);
                return Ok(BookDtoMapper.From(book));
            }

            catch (BookNotFound e)
            {
                return NotFound(new ErrorResponse(e.Message));
            }
        }

        [HttpPost("Register_New_Book")]
        public ActionResult<BookDto> CreateBook([FromBody] BookRequest body)
        {
            try
            {
                var book = _managerBook.CreateBook(body.Id, body?.UserID, body.PublishedType, body.Genre, body.DatePublished, body.Method, body.HasWebSite, body.Title,
                body.Subtitle, body.Description, body.IsActive, body.Price, body.Weight, body.DiscountRate, body.Format,
                body.PageNumber, body.Arguments, body.AuthorName, body.AuthorSurname, body.Role, body.SaleRate, body.Package,
                body.Cover, body.Grammage, body.Print);
                var uri = $"/Insert/{book}";
                return Created(uri, BookDtoMapper.From(book));
            }
            catch (WrongLengthComment ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }

        [HttpDelete("Delete_Book" + "{id:int}")]
        public ActionResult<bool> DeleteBook([FromRoute] int id)
        {
            try
            {
                var book = _managerBook.DeleteBook(id);

                return book;
            }
            catch (BookNotFound ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }

        [HttpPut("Edit_Book")]
        public ActionResult<string> EditBook([FromBody] BookRequest body)
        {
            try
            {
                _managerBook.DeleteBook(body.Id);

                _managerBook.CreateBook(body.Id, body?.UserID, body.PublishedType, body.Genre, body.DatePublished, body.Method, body.HasWebSite, body.Title,
                body.Subtitle, body.Description, body.IsActive, body.Price, body.Weight, body.DiscountRate, body.Format,
                body.PageNumber, body.Arguments, body.AuthorName, body.AuthorSurname, body.Role, body.SaleRate, body.Package,
                body.Cover, body.Grammage, body.Print);

                return Ok();
            }
            catch (WrongLengthComment ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }
    }
}
