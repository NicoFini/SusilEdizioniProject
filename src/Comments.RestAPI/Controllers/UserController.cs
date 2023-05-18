using Microsoft.AspNetCore.Mvc;
using SusilEdizioni.Core;
using SusilEdizioni.Core.Exceptions;
using SusilEdizioni.RestAPI.Mapper;
using SusilEdizioni.RestAPI.Model;

namespace SusilEdizioni.RestAPI.Controllers
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
        
        [HttpGet("Get_All_User")]
        public ActionResult<List<UserDto>> GetAllUser() =>
            Ok(_managerUser.GetAllUsers().Select(s => UserDtoMapper.From(s)).ToList());

        [HttpGet("Get_User_By_Id"+"{id:int}")]
        public ActionResult<UserDto> GetUserById( int id)
        {
            try
            {
                var user = _managerUser.GetUser(id);
                return Ok(UserDtoMapper.From(user));
            }

            catch (UserNotFound e)
            {
                return NotFound(new ErrorResponse(e.Message));
            }
        }
        
        [HttpPost("Register_New_User")]
        public ActionResult<UserDto> CreateUser([FromBody] UserRequest body)
        {
            try
            {
                var user = _managerUser.CreateUser(body.Id, body.Name, body.Surname, body.Email, body.Password, body.IsAdmin);
                var uri = $"/Insert/{user}";
                return Created(uri, UserDtoMapper.From(user));
            }
            catch (WrongLengthComment ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }

        [HttpDelete("Delete_User"+"{id:int}")]
        public ActionResult<bool> DeleteUser([FromRoute] int id)
        {
            try
            {
                var user = _managerUser.DeleteUser(id);
               
                return user;
            }
            catch (UserNotFound ex)
            {
                return BadRequest(new ErrorResponse(ex.Message));
            }
        }

        [HttpPut("Edit_User")]
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

