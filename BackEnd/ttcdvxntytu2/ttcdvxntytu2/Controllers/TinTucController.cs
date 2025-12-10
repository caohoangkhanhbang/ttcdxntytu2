using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ttcdvxntytu2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinTucController : Controller
    {
        public IActionResult TinTuc()
        {
            return View();
        }
    }
}
