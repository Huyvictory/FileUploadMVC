using FileUploadMVC.Data;
using FileUploadMVC.Models;
using FileUploadMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FileUploadMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _context = applicationDbContext;

        }

        public async Task<IActionResult> Index()
        {
            FileService fileService = new FileService();
            var fileuploadViewModel = await fileService.LoadAllFiles(_context);
            ViewBag.Message = TempData["Message"];
            return View(fileuploadViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
