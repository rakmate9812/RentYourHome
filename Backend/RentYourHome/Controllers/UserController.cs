using Microsoft.AspNetCore.Mvc;

namespace RentYourHome.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("users")]
    public ActionResult<IEnumerable<int>> GetUsers()
    {
        try
        {
            return Ok(1);
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting rooms data.");
            return NotFound("Error getting rooms data.");
        }
    }
}