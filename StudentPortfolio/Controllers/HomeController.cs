using Microsoft.AspNetCore.Mvc;
using StudentPortfolio.Services;
using StudentPortfolio.ViewModels;

namespace StudentPortfolio.Controllers;

public class HomeController : Controller
{
    private readonly IPortfolioService _portfolioService;

    public HomeController(IPortfolioService portfolioService) => _portfolioService = portfolioService;

    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            FeaturedProjects = _portfolioService.GetProjects().Take(3).ToList(),
            FeaturedSkills = _portfolioService.GetSkills().Take(22).ToList()
        };
        return View(model);
    }

    public IActionResult Error() => View();
}
