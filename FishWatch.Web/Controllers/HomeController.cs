using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FishWatch.Web.Models;
using FishWatch.Web.Services;
using Microsoft.Extensions.Logging;

namespace FishWatch.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FishService _fishService;

    public HomeController(ILogger<HomeController> logger, FishService fishService)
    {
        _logger = logger;
        _fishService = fishService;
    }

    public async Task<IActionResult> Index()
    {
        var model = new IndexViewModel();
        model.Fishes = await _fishService.GetAll();
        return View(model);
    }

    [HttpGet("fish/{id}")]
    public async Task<IActionResult> Fish(string id)
    {
        var model = new FishViewModel();
        model.Fish = await _fishService.Get(id);
        if (model.Fish == null)
        {
            return RedirectToAction("Index");
        }
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}