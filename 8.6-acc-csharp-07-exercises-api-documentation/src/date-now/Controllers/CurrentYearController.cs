using Microsoft.AspNetCore.Mvc;

namespace DateNow.Controllers;

[ApiController]
[Route("[controller]")]
public class CurrentYearController : ControllerBase
{
    /// <summary>
    /// This function is to informate the current year
    /// </summary>
    /// <returns>The current year</returns>
    /// <response code="200">Return the current year</response>   
    [HttpGet]
    public ActionResult Get()
    {
        var date = DateTime.Now.Year;
        return Ok(date);
    }
}
