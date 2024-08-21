using Microsoft.AspNetCore.Mvc;
namespace HelloWorldWebService.Controllers; [ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    // GET: api/helloworld [HttpGet]
    public ActionResult<string> Get()
    {
        return "Hello, World!";
    }
}
