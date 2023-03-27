using Microsoft.AspNetCore.Mvc;
namespace SampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class PersonsController: ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            var persons = new string[]{
                "Mohamad",
                "Donald duck",
                "Bathman",
                "Thor",
                "Tony Stark"
            };
            return Ok(persons);
        }
    }
}