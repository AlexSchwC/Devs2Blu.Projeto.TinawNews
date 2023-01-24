using Devs2Blu.Projeto.TinawNews.Domain.IServices;
using Devs2Blu.Projeto.TinawNews.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Devs2Blu.Projeto.TinawNews.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private readonly INewsService _service;

        public NewsController(ILogger<NewsController> logger,
                                    INewsService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // To list all news
            // Get of NewsRepository through Dependecy Injection (DI) (INewsService)
            return View(_service.FindAll());
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}