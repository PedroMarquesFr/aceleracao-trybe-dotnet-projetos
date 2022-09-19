using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{

    private readonly ILogger<HelloController> _logger;

    public HelloController(ILogger<HelloController> logger)
    {
        _logger = logger;
    }


    [HttpGet]
    public string Get()
    {
        return "hello, use /{language} to get a hello in your language!";
    }

    [HttpGet("{language}")]
    public string Get(string language)
    {
        switch (language)
        {
            case "br":
                return "[br] : Olá";
            case "en":
                return "[en] : Hello";
            case "es":
                return "[es] : Hola";
            case "de":
                return "[de] : Hallo";
            default:
                return "Não conheço essa!";
        }
    }
}
