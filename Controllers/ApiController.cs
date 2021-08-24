using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aec_mvc_entity_framework.Models;
using aec_mvc_entity_framework.Services;

namespace aec_mvc_entity_framework.Controllers
{
    [Route("[controller]")]
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.ApiCandidatos = await ApiService.GetApiCandidatos();
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
