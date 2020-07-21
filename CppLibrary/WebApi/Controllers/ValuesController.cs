using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [DllImport(@"F:\Assignment\CppLibrary\x64\Release\CppLibrary.dll",
            EntryPoint = "add", CallingConvention = CallingConvention.StdCall)]
        public static extern int Add(int a, int b);

        [DllImport(@"F:\Assignment\CppLibrary\x64\Release\CppLibrary.dll",
            EntryPoint = "mul", CallingConvention = CallingConvention.StdCall)]
        public static extern int Multiple(int a, int b);

        [HttpGet("add")]
        public IActionResult AddValues([FromQuery] int a, [FromQuery] int b)
        {
            int c = Add(a, b);
            return Ok("Adding " + a + " and " + b + " equals to " + c);
        }

        [HttpGet("multiply")]
        public IActionResult MultipleValues([FromQuery] int a, [FromQuery] int b)
        {
            int c = Multiple(a, b);
            return Ok("Mutiplying " + a + " and " + b + " equals to " + c);
        }

    }
}
