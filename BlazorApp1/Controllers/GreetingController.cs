using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello, World!";
    }
}
