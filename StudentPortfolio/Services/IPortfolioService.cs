using StudentPortfolio.Models;

namespace StudentPortfolio.Services;

public interface IPortfolioService
{
    List<Project> GetProjects();
    Project? GetProjectBySlug(string slug);
    List<Skill> GetSkills();
    List<ExperienceItem> GetExperience();
}
