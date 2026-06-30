using Microsoft.AspNetCore.Mvc;
using StudentPortfolio.Services;
using StudentPortfolio.ViewModels;

namespace StudentPortfolio.Controllers;

public class ProjectsController : Controller
{
    private readonly IPortfolioService _portfolioService;
    public ProjectsController(IPortfolioService portfolioService) => _portfolioService = portfolioService;

    public IActionResult Index()
    {
        var projects = _portfolioService.GetProjects();
        return View(new ProjectsViewModel
        {
            Projects = projects,
            Categories = projects.Select(p => p.Category).Distinct().ToList()
        });
    }

    public IActionResult Details(string slug)
    {
        var project = _portfolioService.GetProjectBySlug(slug);
        if (project is null) return NotFound();
        return View(project);
    }
}
