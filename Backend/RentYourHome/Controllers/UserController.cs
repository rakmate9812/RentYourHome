using Microsoft.AspNetCore.Mvc;

namespace RentYourHome.Controllers;

[ApiController]
[Route("api/")]
public class UserController : ControllerBase
{
    [HttpPost("user")]
    public ActionResult<int> PostUser()
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting user data.");
            return NotFound("Error getting user data.");
        }
    }

    [HttpGet("users")]
    public ActionResult<int> GetUsers()
    {
        try
        {
            return Ok(1);
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting user data.");
            return NotFound("Error getting user data.");
        }
    }

    [HttpGet("user/{id}")]
    public ActionResult<int> GetUserById(int id)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting user data.");
            return NotFound("Error getting user data.");
        }
    }

    [HttpDelete("user/{id}")]
    public ActionResult<int> DeleteUserById(int id)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting user data.");
            return NotFound("Error getting user data.");
        }
    }
}