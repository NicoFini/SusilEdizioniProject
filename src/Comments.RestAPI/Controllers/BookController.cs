﻿using Microsoft.AspNetCore.Mvc;
using SunsilEdizioni.Core.Exceptions;
using SunsilEdizioni.Core;
using SunsilEdizioni.RestAPI.Mapper;
using SunsilEdizioni.RestAPI.Model;
using SunsilEdizioni.Core.Service;

namespace SunsilEdizioni.RestAPI.Controllers
{
    public class BookController
    {
        [ApiController]
        [Route("Book")]
        public class BooksController : ControllerBase
        {
            private ApplicationManagerBooks _managerBook;

            public BooksController(ApplicationManagerBooks managerBook)
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
                    var s = _managerBook.GetBook(id);
                    return Ok(BookDtoMapper.From(s));
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
                    var c = _managerBook.CreateBook(body.Id, body.Title, body.Author, body.Price, body.Publisher, body.YearPublished, body.ISBN);
                    var uri = $"/Insert/{c}";
                    return Created(uri, BookDtoMapper.From(c));
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
                    var c = _managerBook.DeleteBook(id);

                    return c;
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
                    _managerBook.CreateBook(body.Id, body.Title, body.Author, body.Price, body.Publisher, body.YearPublished, body.ISBN);
                    return Ok();
                }
                catch (WrongLengthComment ex)
                {
                    return BadRequest(new ErrorResponse(ex.Message));
                }
            }
        }
    }
}
