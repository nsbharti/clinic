using API.Errors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("error/{code}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorControllre:BaseApiController
    {
         public IActionResult Error(int code)
         {
             return new ObjectResult(new ApiResponces(code));
         }
    }
}