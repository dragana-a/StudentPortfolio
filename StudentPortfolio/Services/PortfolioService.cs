using StudentPortfolio.Models;

namespace StudentPortfolio.Services;

public class PortfolioService : IPortfolioService
{
    public List<Project> GetProjects() => new()
    {
        new Project
        {
            Id = 1,
            Slug = "multi-user-bakery-website",
            Title = "Multi-User Baking Website",
            Category = "ASP.NET Core",
            Summary = "A full-stack bakery ordering platform with customer and admin workflows.",
            Description = "Replace this with your real capstone details. This project demonstrates MVC architecture, Identity authentication, order management, file uploads, validation, and role-based access.",
            ImageUrl = "/images/project-bakery.svg",
            Timeline = "Jan 2026 - Apr 2026",
            GitHubUrl = "https://github.com/yourusername/bakery-capstone",
            LiveDemoUrl = "#",
            DocumentationUrl = "#",
            TechStack = new() { "C#", "ASP.NET Core MVC", "Entity Framework Core", "Identity", "Bootstrap 5", "SQL Server" },
            Features = new() { "Customer order requests", "Admin status management", "Image upload validation", "Responsive product catalog" },
            Challenges = new() { "Designing role-based workflows", "Handling file uploads securely", "Keeping the UI simple for customers" },
            LessonsLearned = new() { "MVC separation of concerns", "Server-side validation", "Accessibility-first UI design" },
            FutureImprovements = new() { "Payment integration", "Email notifications", "Advanced analytics dashboard" }
        },
        new Project
        {
            Id = 2,
            Slug = "ai-stock-market-analysis",
            Title = "AI Boom Stock Analysis",
            Category = "Data Analysis",
            Summary = "Python analysis comparing major technology stocks during the AI market boom.",
            Description = "Replace with your real analysis findings. This project uses Python, pandas, and visualizations to compare growth, volatility, returns, and correlations.",
            ImageUrl = "/images/project-data.svg",
            Timeline = "Jun 2026",
            GitHubUrl = "https://github.com/yourusername/ai-stock-analysis",
            LiveDemoUrl = "#",
            DocumentationUrl = "#",
            TechStack = new() { "Python", "Pandas", "Matplotlib", "Jupyter", "Data Visualization" },
            Features = new() { "Daily returns", "Growth ranking", "Correlation matrix", "Portfolio comparison" },
            Challenges = new() { "Cleaning multiple CSV files", "Explaining volatility clearly", "Creating recruiter-friendly charts" },
            LessonsLearned = new() { "Financial data preparation", "Interpreting visual trends", "Communicating results" },
            FutureImprovements = new() { "Automated data refresh", "Interactive dashboard", "Risk-adjusted return metrics" }
        },
        new Project
        {
            Id = 3,
            Slug = "percus-personalized-video-player",
            Title = "Personalized Video Player POC",
            Category = "Client Project",
            Summary = "A proof-of-concept browser player that renders personalized Lottie templates from JSON data.",
            Description = "Replace with your real client-safe description. This project focused on JSON-driven personalization, error handling, configuration files, and embeddable playback.",
            ImageUrl = "/images/project-player.svg",
            Timeline = "Jan 2026 - Apr 2026",
            GitHubUrl = "#",
            LiveDemoUrl = "#",
            DocumentationUrl = "#",
            TechStack = new() { "JavaScript", "Lottie", "HTML", "CSS", "JSON", "Git" },
            Features = new() { "Template loading", "JSON data merge", "Playback controls", "Fallback error animation" },
            Challenges = new() { "Synchronizing content safely", "Avoiding hardcoded values", "Improving handoff documentation" },
            LessonsLearned = new() { "Client communication", "Config-driven design", "Proof-of-concept delivery" },
            FutureImprovements = new() { "AI voice synchronization", "More templates", "Performance testing" }
        }
    };

    public Project? GetProjectBySlug(string slug) => GetProjects().FirstOrDefault(p => p.Slug == slug);

    public List<Skill> GetSkills() => new()
    {
        new() { Name = "C#", Category = "Programming Languages", Proficiency = 85, IconClass = "bi bi-braces" },
        new() { Name = "JavaScript", Category = "Programming Languages", Proficiency = 80, IconClass = "bi bi-filetype-js" },
        new() { Name = "Python", Category = "Programming Languages", Proficiency = 75, IconClass = "bi bi-filetype-py" },
        new() { Name = "ASP.NET Core MVC", Category = "Frameworks", Proficiency = 85, IconClass = "bi bi-window-stack" },
        new() { Name = "React", Category = "Frameworks", Proficiency = 65, IconClass = "bi bi-lightning" },
        new() { Name = "HTML5/CSS3", Category = "Web Technologies", Proficiency = 90, IconClass = "bi bi-code-square" },
        new() { Name = "Bootstrap 5", Category = "Web Technologies", Proficiency = 88, IconClass = "bi bi-bootstrap" },
        new() { Name = "SQL Server", Category = "Databases", Proficiency = 78, IconClass = "bi bi-database" },
        new() { Name = "SQLite", Category = "Databases", Proficiency = 72, IconClass = "bi bi-hdd-stack" },
        new() { Name = "Git/GitHub", Category = "Version Control", Proficiency = 82, IconClass = "bi bi-github" },
        new() { Name = "xUnit", Category = "Testing", Proficiency = 62, IconClass = "bi bi-check2-square" },
        new() { Name = "Visual Studio", Category = "IDEs & Tools", Proficiency = 88, IconClass = "bi bi-terminal" }
    };

    public List<ExperienceItem> GetExperience() => new()
    {
        new()
        {
            Title = "International Research Intern",
            Organization = "Institute of Technology and Business, Czech Republic",
            DateRange = "May 2026 - Aug 2026",
            Type = "Internship",
            Description = "Applied data analysis, forecasting, and research methods in an international academic environment.",
            Highlights = new() { "Worked with Python-based analysis", "Prepared research visuals", "Strengthened communication across cultures" }
        },
        new()
        {
            Title = "Software Development Student",
            Organization = "Mohawk College",
            DateRange = "2024 - Present",
            Type = "Education",
            Description = "Completed coursework in web development, databases, software engineering, analytics, and application development.",
            Highlights = new() { "Built ASP.NET Core MVC applications", "Created database-backed projects", "Collaborated on team-based client work" }
        },
        new()
        {
            Title = "Client Project Developer",
            Organization = "Percus Inc. POC Project",
            DateRange = "Jan 2026 - Apr 2026",
            Type = "Client Project",
            Description = "Contributed to a personalized video player proof of concept with JSON-driven rendering and error handling.",
            Highlights = new() { "Improved config structure", "Added fallback handling", "Supported final documentation" }
        }
    };
}
