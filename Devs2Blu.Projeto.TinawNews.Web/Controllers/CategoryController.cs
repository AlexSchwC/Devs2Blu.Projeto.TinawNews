using Devs2Blu.Projeto.TinawNews.Domain.IServices;
using Devs2Blu.Projeto.TinawNews.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Devs2Blu.Projeto.TinawNews.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ICategoryService _service;

        public CategoryController(ILogger<CategoryController> logger,
                                    ICategoryService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            // To list all categories
            // Get of CategoryRepository through Dependecy Injection (DI) (ICategoryService)
            return View(_service.FindAll());
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}