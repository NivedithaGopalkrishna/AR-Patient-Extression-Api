using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace healthApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UpperBodyController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Work in Progress!");
        }
    }
}
