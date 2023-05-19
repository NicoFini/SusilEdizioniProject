﻿using Microsoft.AspNetCore.Mvc;
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
                var book = _managerBook.CreateBook(body.Id, body.Title, body.Author, body.Price, body.Publisher, body.YearPublished, body.ISBN, body.UserID);
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
                _managerBook.CreateBook(body.Id, body.Title, body.Author, body.Price, body.Publisher, body.YearPublished, body.ISBN, body.UserID);
                return Ok();
            }
            catch (WrongLengthComment ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }
    }
}
