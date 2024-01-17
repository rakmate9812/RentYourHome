using Microsoft.AspNetCore.Mvc;

namespace RentYourHome.Controllers;

[ApiController]
[Route("api/")]
public class AdController : ControllerBase
{
    [HttpPost("ad")]
    public ActionResult<int> PostAd()
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting ad data.");
            return NotFound("Error getting ad data.");
        }
    }

    [HttpGet("ads")]
    public ActionResult<int> GetAds()
    {
        try
        {
            return Ok(1);
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting ad data.");
            return NotFound("Error getting ad data.");
        }
    }

    [HttpGet("ad/{id}")]
    public ActionResult<int> GetAdById(int id)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting ad data.");
            return NotFound("Error getting ad data.");
        }
    }

    [HttpDelete("ad/{id}")]
    public ActionResult<int> DeleteAdById(int id)
    {
        try
        {
            return Ok();
        }
        catch (Exception e)
        {
            //_logger.LogError(e, "Error getting ad data.");
            return NotFound("Error getting ad data.");
        }
    }
}