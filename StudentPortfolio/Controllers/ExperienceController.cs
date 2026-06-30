using Microsoft.AspNetCore.Mvc;
using StudentPortfolio.Services;
namespace StudentPortfolio.Controllers;
public class ExperienceController : Controller
{
    private readonly IPortfolioService _portfolioService;
    public ExperienceController(IPortfolioService portfolioService) => _portfolioService = portfolioService;
    public IActionResult Index() => View(_portfolioService.GetExperience());
}
