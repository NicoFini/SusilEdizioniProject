using Microsoft.AspNetCore.Mvc;
using System;
using SunsilEdizioni.Core;
using SunsilEdizioni.Core.Exceptions;
using SunsilEdizioni.Core.Model;
using SunsilEdizioni.Core.Service;
using SunsilEdizioni.RestAPI.Mapper;
using SunsilEdizioni.RestAPI.Model;
using Microsoft.AspNetCore.Cors;

namespace SunsilEdizioni.RestAPI.Controllers
{
    [ApiController]
    [Route("User")]
    public class UsersController : ControllerBase
    {
        private ApplicationManagerUsers _managerUser;

        public UsersController(ApplicationManagerUsers managerUser)
        {
            _managerUser = managerUser;
        }
        
        [HttpGet("Get_All")]
        public ActionResult<List<UserDto>> GetAllUser() =>
            Ok(_managerUser.GetAllUsers().Select(s => UserDtoMapper.From(s)).ToList());

        [HttpGet("Get_By_Id"+"{id:int}")]
        public ActionResult<UserDto> GetUserById( int id)
        {
            try
            {
                var s = _managerUser.GetUser(id);
                return Ok(UserDtoMapper.From(s));
            }

            catch (UserNotFound e)
            {
                return NotFound(new ErrorResponse(e.Message));
            }
        }
        
        [HttpPost("Register_New")]
        public ActionResult<UserDto> CreateUser([FromBody] UserRequest body)
        {
            try
            {
                var c = _managerUser.CreateUser(body.Id, body.Name, body.Surname, body.Email, body.Password, body.IsAdmin);
                var uri = $"/Insert/{c}";
                return Created(uri, UserDtoMapper.From(c));
            }
            catch (WrongLengthComment ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }
        [HttpDelete("Delete_Comment"+"{id:int}")]
        public ActionResult<bool> DeleteUser([FromRoute] int id)
        {
            try
            {
                var c = _managerUser.DeleteUser(id);
               
                return c;
            }
            catch (UserNotFound ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }

        [HttpPut("Modify_Comment")]
        public ActionResult<string> EditUser([FromBody] UserRequest body)
        {
            try
            {
                _managerUser.DeleteUser(body.Id);
                _managerUser.CreateUser(body.Id, body.Name, body.Surname, body.Email, body.Password, body.IsAdmin);
                return Ok();
            }
            catch (WrongLengthComment ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }
    }
}
