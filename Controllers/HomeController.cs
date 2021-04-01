using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BridgeMonitor.Models;

namespace BridgeMonitor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var ClosingModel = new ClosingList();
            await ClosingModel.fetchData();

            return View(ClosingModel);
        }
        public async Task<IActionResult> All()
        {
            var ClosingModel = new ClosingList();
            await ClosingModel.fetchData();

            return View(ClosingModel);
        }
        public async Task<IActionResult> Details(int id)
        {
            var ClosingModel = new ClosingList();
            await ClosingModel.fetchData();
            ClosingModel.SetDetail(id);

            return View(ClosingModel);
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
