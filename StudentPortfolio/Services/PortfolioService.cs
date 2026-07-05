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

            Description = "A full-stack web application developed for a small baking business to streamline product management and custom order requests. The platform allows customers to browse products, create accounts, submit detailed custom cake and dessert orders, and track their requests through a centralized system. The application replaces traditional communication through social media and text messaging with an organized, database-driven solution, providing a more efficient experience for both customers and administrators. Designed with responsive layouts and accessibility in mind, the website delivers a seamless experience across desktop and mobile devices.",

            ImageUrl = "/images/bakery-website-1.svg",
            Timeline = "2026",
            GitHubUrl = "https://github.com/dragana-a/bakery-capstone",
            LiveDemoUrl = "#",
    
            TechStack = new() { 
                "C#", 
                "ASP.NET Core MVC", 
                "Entity Framework Core", 
                "Bootstrap 5", 
                "SQL Server" 
            },
            Features = new() { 
                "Customer order requests", 
                "Admin status management", 
                "Image upload validation", 
                "Responsive product catalog" 
            },
            Challenges = new() { 
                "Designing role-based workflows", 
                "Handling file uploads securely", 
                "Keeping the UI simple for customers" 
            },
            LessonsLearned = new() { 
                "MVC separation of concerns", 
                "Server-side validation", 
                "Accessibility-first UI design" 
            },
            FutureImprovements = new() { 
                "Email notifications", 
                "Advanced analytics dashboard" 
            }
        },


        new Project
        {
            Id = 2,
            Slug = "ai-stock-market-analysis",
            Title = "AI Boom Stock Analysis",
            Category = "Data Analysis",
            Summary = "Python analysis comparing major technology stocks during the AI market boom.",

            Description = "Replace with your real analysis findings. This project uses Python, pandas, and visualizations to compare growth, volatility, returns, and correlations.",

            ImageUrl = "/images/stocks.svg",
            Timeline = "2026",
            GitHubUrl = "https://github.com/dragana-a/AI-Data-Analysis.git",
            LiveDemoUrl = "#",

            TechStack = new() { 
                "Python", 
                "Pandas", 
                "Matplotlib", 
                "Jupyter", 
                "Data Visualization" 
            },
            Features = new() { 
                "Daily returns", 
                "Growth ranking", 
                "Correlation matrix", 
                "Portfolio comparison" 
            },
            Challenges = new() { 
                "Cleaning multiple CSV files", 
                "Explaining volatility clearly", 
                "Creating recruiter-friendly charts" 
            },
            LessonsLearned = new() { 
                "Financial data preparation", 
                "Interpreting visual trends", 
                "Communicating results" 
            },
            FutureImprovements = new() { 
                "Automated data refresh", 
                "Interactive dashboard", 
                "Risk-adjusted return metrics" 
            }
        },


        new Project
        {
            Id = 3,
            Slug = "percus-personalized-video-player",
            Title = "Personalized Video Player POC",
            Category = "Client Project",

            Summary = "A proof-of-concept browser player that renders personalized Lottie templates from JSON data.",

            Description = "Replace with your real client-safe description. This project focused on JSON-driven personalization, error handling, configuration files, and embeddable playback.",

            ImageUrl = "/images/personalized-player-1.svg",
            Timeline = "Jan 2026 - Apr 2026",
            GitHubUrl = "#",
            LiveDemoUrl = "https://youtu.be/qoh7FBTgdOs",

            TechStack = new() { 
                "JavaScript", 
                "Lottie", 
                "HTML", 
                "CSS", 
                "JSON", 
                "Git" 
            },
            Features = new() { 
                "Template loading",
                "JSON data merge", 
                "Playback controls", 
                "Fallback error animation" 
            },
            Challenges = new() { 
                "Synchronizing content safely", 
                "Avoiding hardcoded values", 
                "Improving handoff documentation" 
            },
            LessonsLearned = new() { 
                "Client communication", 
                "Config-driven design", 
                "Proof-of-concept delivery" 
            },
            FutureImprovements = new() { 
                "AI voice synchronization", 
                "More templates", 
                "Performance testing" }
        },


        new Project
        {
            Id = 4,
            Slug = "5-stack",
            Title = "5-Stack",
            Category = "Full-Stack Web Application",

            Summary = "A full-stack social media platform inspired by Twitter where users can create accounts, build profiles, and share posts.",

            Description = "5-Stack is a full-stack web application that recreates core social media functionality. Users can register for an account, log in securely, customize their profile, create and manage posts, and interact with content through an intuitive user interface. The project demonstrates full-stack development principles including authentication, database integration, CRUD operations, and responsive web design.",

            ImageUrl = "/images/5-stack-platform.svg",

            Timeline = "2025",

            GitHubUrl = "https://github.com/dragana-a/5-Stack",

            LiveDemoUrl = "#",

            TechStack = new()
            {
                "PHP",
                "HTML5",
                "CSS3",
                "JavaScript",
                "MySQL"
            },
            Features = new()
            {
                "User registration and authentication",
                "Secure login system",
                "Custom user profiles",
                "Create, edit, and delete posts",
                "Personal profile pages",
            },
            Challenges = new()
            {
                "Implementing secure user authentication",
                "Designing the relational database",
                "Managing user sessions and authorization",
                "Connecting the frontend with backend data"
            },
            LessonsLearned = new()
            {
                "Building complete CRUD applications",
                "Working with authentication and authorization",
                "Using Entity Framework Core with SQL Server",
                "Designing scalable full-stack web applications"
            },
            FutureImprovements = new()
            {
                "Like and comment functionality",
                "Follow and follower system",
                "Private messaging",
                "Real-time notifications",
                "Image uploads",
                "Search functionality"
            }
        },

        
        new Project
        {
            Id = 5,
            Slug = "portfolio-website",
            Title = "Portfolio Website",
            Category = "Web Development",

            Summary = "A personal portfolio website showcasing projects, skills, and experience.",
            Description = "This portfolio website is designed to present my professional work, including projects, skills, and experience. It serves as a digital resume and a platform to demonstrate my capabilities in web development and design.",

            ImageUrl = "/images/portfolio-website.svg",
            Timeline = "2026",
            GitHubUrl = "https://github.com/dragana-a/StudentPortfolio.git",
            LiveDemoUrl = "#",
            TechStack = new()
            {
                "C#",
                "ASP.NET Core MVC",
                "Blazor",
                "Bootstrap 5",
                "HTML5",
                "CSS3"
            },
            Features = new()
            {
                "Responsive design",
                "Project showcase",
                "Skills and experience section",
                "Contact form"
            },
            Challenges = new()
            {
                "Designing a clean and professional layout",
                "Ensuring cross-browser compatibility",
                "Implementing responsive design for various devices"
                },
            LessonsLearned = new()
            {
                "Creating a personal brand through web design",
                "Using Blazor for interactive components",
                "Optimizing website performance and accessibility"
                },
            FutureImprovements = new()
            {
                "Adding a blog section",
                "Integrating social media links",
                "Implementing SEO best practices"
            }
        },


        new Project
        {
            Id = 6,
            Slug = "csharp-game-development",
            Title = "Kew's Quest: Dragon's Lair",
            Category = "Game Development",

            Summary = "A game development project using Godot and C# to create an interactive gaming experience.",

            Description = "This project involves the development of a game using Godot, focusing on gameplay mechanics, user interface design, and interactive elements. The game is designed to provide an engaging experience for players, incorporating various levels, challenges, and rewards.",

            ImageUrl = "/images/csharp-game-1.svg",
            Timeline = "2025",
            GitHubUrl = "https://github.com/dragana-a/Kew-s-Quest-Dragon-s-Lair.git",
            LiveDemoUrl = "https://www.youtube.com/watch?si=VQvVLW8EdTWUV3Yr&v=VqaVK2Zo42Q&feature=youtu.be",
            TechStack = new()
            {
                "C#",
                "Godot",
                "Game Design",
                "2D/3D Graphics",
                "Animation"
                },
            Features = new()
            {
                "Interactive gameplay",
                "Points system and scoring",
                "complex level design",
                "Character animations and effects"
                },
            Challenges = new()
            {
                "Implementing smooth character controls",
                "Designing character annimations",
                "Balancing game difficulty"
            },
            LessonsLearned = new()
            {
                "Game development principles",
                "Using Godot engine effectively",
                "Creating engaging user experiences"
                },
            FutureImprovements = new()
            {
                "Adding more levels and challenges",
                "Creating main menu and settings",
                "Enhancing graphics and sound effects",
                "Adding more complex gameplay mechanics"
            }
        },


        new Project
        {
            Id = 7,
            Slug = "javascript-game",
            Title = "Mousin' Around",
            Category = "Game Development",

            Summary = "A browser-based game developed using JavaScript, HTML, and CSS, featuring interactive gameplay and user engagement.",
            Description = "This project involves creating a browser-based game that challenges players to navigate through various obstacles and achieve high scores. The game is designed to be engaging and interactive, utilizing JavaScript for game logic, HTML for structure, and CSS for styling. Saving player hghscore with multiple levels of difficulty to be selected by the player.",

            ImageUrl = "/images/mouse-cat-1.svg",
            Timeline = "2024",
            GitHubUrl = "https://github.com/dragana-a/Mousin--Around.git",
            LiveDemoUrl = "https://dragana-a.github.io/Mousin--Around/",
            TechStack = new()
            {
                "JavaScript",
                "HTML5",
                "CSS3",
            },
            Features = new()
            {
                "Interactive gameplay",
                "Multiple levels of difficulty",
                "High score tracking",
                "Responsive design for various devices"
            },
            Challenges = new()
            {
                "Creating and mapping game figures",
                "Designing engaging levels",
                "Ensuring cross-browser compatibility"
            },
            LessonsLearned = new()
            {
                "Game development using JavaScript",
                "Implementing responsive design",
                "Creating engaging user experiences"
            }
        },


        new Project
        {
            Id = 8,
            Slug = "brain-tumor-segmentation",
            Title = "Brain Tumor Segmentation Analysis",
            Category = "Data Analysis",

            Summary = "A medical imaging analysis project using Python and machine learning to detect and segment brain tumors from MRI scans.",
            Description = "This project focuses on medical image analysis using deep learning techniques to identify and segment brain tumors from MRI scans. The application processes brain scan images, applies preprocessing techniques, and uses convolutional neural networks to accurately detect tumor regions. The goal is to assist medical professionals in early diagnosis and treatment planning by providing automated segmentation results with visualization overlays.",
            ImageUrl = "/images/brain-ai-1.svg",
            Timeline = "2025",
            GitHubUrl = "https://github.com/dragana-a/Brain-Tumor-Segmentation.git",
            LiveDemoUrl = "#",
            TechStack = new()
            {
                "Python",
                "TensorFlow",
                "Keras",
                "OpenCV",
                "NumPy",
                "pandas",
                "matplotlib"
            },
            Features = new()
            {
                "MRI scan preprocessing and normalization",
                "Brain tumor detection and segmentation",
                "Multi-class tumor classification",
                "Visualization overlays on original scans",
                "Performance metrics and accuracy reporting"
            },
            Challenges = new()
            {
                "Processing high-resolution medical imaging data",
                "Handling imbalanced datasets",
                "Ensuring accurate tumor boundary detection",
                "Meeting medical imaging standards for accuracy"
            },
            LessonsLearned = new()
            {
                "Medical image processing techniques",
                "Deep learning for computer vision",
                "Convolutional neural network architecture",
                "Ethical considerations in healthcare AI"
            },
            FutureImprovements = new()
            {
                "3D volumetric segmentation",
                "Real-time processing optimization",
                "Integration with DICOM medical imaging standards",
                "Multi-modal imaging fusion (MRI, CT scans)"
            }
        },
        new Project
        {
            Id = 9,
            Slug = "gold-and-oil-data",
            Title = "Gold and Oil Data Analysis",
            Category = "Data Analysis",

            Summary = "A data analysis project comparing gold and oil market trends from the previous decade using Python and visualization techniques.",
            Description = "This project analyzes historical data of gold and oil markets over the past decade. It involves data collection, cleaning, and visualization to identify trends, correlations, and insights. The analysis helps investors and analysts make informed decisions based on historical market behavior.",
            ImageUrl = "/images/gold-oil-analysis.svg",
            Timeline = "2026",
            GitHubUrl = "https://github.com/dragana-a/Gold-and-Oil-Stock-Data-Analysis.git",
            LiveDemoUrl = "#",
            TechStack = new()
            {
                "Python",
                "pandas",
                "matplotlib",
                "NumPy",
                "Data Visualization"
            },
            Features = new()
            {
                "Historical data analysis of gold and oil markets",
                "Trend identification and correlation analysis",
                "Visualization of market behavior over time",
                "Insights for investment decision-making"
                },
            Challenges = new()
            {
                "Collecting and cleaning large datasets",
                "Identifying meaningful trends and correlations",
                "Creating clear and informative visualizations"
                },
            LessonsLearned = new()
            {
                "Data analysis techniques using Python",
                "Visualization best practices for financial data",
                "Interpreting market trends and correlations"
                },
        },
        new Project          {
            Id = 10,
            Slug = "thriftshop-tracker",
            Title = "Thriftshop Tracker",
            Category = "Web Application",
            Summary = "A JavaScript-based website that uses the user's location to show nearby thrift stores.",
            Description = "This project is a personal budget tracker that helps users monitor their income and expenses. It provides features forA location-based web app that uses JavaScript and the user's current GPS location to display nearby thrift stores. The project focuses on interactive maps, geolocation, and helping users quickly find second-hand stores near them.",
            ImageUrl = "/images/thrift-shop-gps.svg",
            GitHubUrl = "https://github.com/dragana-a/Thrift-Store-GPS.git",
            Timeline = "2025",
            LiveDemoUrl = "#",
            TechStack = new()
            {
                "JavaScript",
                "HTML",
                "CSS",
                "Geolocation API"
            },
            Features = new()
            {
                "Uses the user's current location",
                "Displays nearby thrift stores",
                "Interactive location-based search",
                "Simple and user-friendly interface"
            },
            Challenges = new()
            {
                "Working with browser geolocation permissions",
                "Handling location accuracy",
                "Displaying relevant nearby results"
            },
            LessonsLearned = new()
            {
                "Using JavaScript geolocation features",
                "Building location-based web applications",
                "Improving user experience with map-based tools"
            }
        }
    };

    public Project? GetProjectBySlug(string slug) => GetProjects().FirstOrDefault(p => p.Slug == slug);

    public List<Skill> GetSkills() => new()
{
    new()
    {
        Name = "C#",
        Category = "Programming Languages",
        IconClass = "devicon-csharp-plain colored"
    },

    new()
    {
        Name = "JavaScript",
        Category = "Programming Languages",
        IconClass = "devicon-javascript-plain colored"
    },

    new()
    {
        Name = "Python",
        Category = "Programming Languages",
        IconClass = "devicon-python-plain colored"
    },

    new()
    {
        Name = "ASP.NET Core MVC",
        Category = "Frameworks",
        IconClass = "devicon-dotnetcore-plain colored"
    },
    new()
    {
        Name = "Blazor",
        Category = "Frameworks",
        IconClass = "devicon-blazor-plain colored"
    },

    new()
    {
        Name = "React",
        Category = "Frameworks",
        IconClass = "devicon-react-original colored"
    },

    new()
    {
        Name = "HTML5",
        Category = "Web Technologies",
        IconClass = "devicon-html5-plain colored"
    },
    new()
    {
        Name = "CSS3",
        Category = "Web Technologies",
        IconClass = "devicon-css3-plain colored"
    },

    new()
    {
        Name = "Bootstrap 5",
        Category = "Web Technologies",
        IconClass = "devicon-bootstrap-plain colored"
    },

    new()
    {
        Name = "SQL Server",
        Category = "Databases",
        IconClass = "devicon-microsoftsqlserver-plain colored"
    },

    new()
    {
        Name = "SQLite",
        Category = "Databases",
        IconClass = "devicon-sqlite-plain colored"
    },

    new()
    {
        Name = "MongoDB",
        Category = "Databases",
        IconClass = "devicon-mongodb-plain colored"
    },

    new()
    {
        Name = "xUnit",
        Category = "Testing",
        IconClass = "devicon-dotnetcore-plain colored"
    },

    new()
    {
        Name = "Visual Studio",
        Category = "IDEs & Tools",
        IconClass = "devicon-visualstudio-plain colored"
    },
    new()
    {
        Name = "VSCode",
        Category = "IDEs & Tools",
        IconClass = "devicon-vscode-plain colored"
    },
    new()
    {
        Name = "JetBrains",
        Category = "IDEs & Tools",
        IconClass = "devicon-jetbrains-plain colored"
    },
    new()
    {
        Name = "NumPy",
        Category = "Data Analysis",
        IconClass = "devicon-numpy-plain colored"
    },
    new()
    {
        Name = "Pandas",
        Category = "Data Analysis",
        IconClass = "devicon-pandas-plain colored"
    },
    new()
    {
        Name = "GitHub",
        Category = "Version Control",
        IconClass = "devicon-github-original"
    },
    new()
    {
        Name = "Java",
        Category = "Programming Languages",
        IconClass = "devicon-java-plain colored"
    },
    new()
    {
        Name = "PHP",
        Category = "Programming Languages",
        IconClass = "devicon-php-plain colored"
    },
    new()
    {
        Name = "TypeScript",
        Category = "Programming Languages",
        IconClass = "devicon-typescript-plain colored"
    },
    new()
    {
        Name = "Swift",
        Category = "Programming Languages",
        IconClass = "devicon-swift-plain colored"
    },
    new()
    {
        Name = "AWS",
        Category = "Cloud Platforms",
        IconClass = "devicon-amazonwebservices-plain colored"
    },

    new()
    {
        Name = "Microsoft Azure",
        Category = "Cloud Platforms",
        IconClass = "devicon-azure-plain colored"
    },
    new()
    {
        Name = "Figma",
        Category = "Web Technologies",
        IconClass = "devicon-figma-plain colored"
    },
    new()
    {
        Name = "Godot",
        Category = "Game Development",
        IconClass = "devicon-godot-plain colored"
    },
    new()
    {
        Name = "Unity",
        Category = "Game Development",
        IconClass = "devicon-unity-plain colored"
    },
    new()
    {
        Name = "Matplotlib",
        Category = "Data Analysis",
        IconClass = "devicon-matplotlib-plain colored"   
    },
    new()
    {
        Name = "WordPress",
        Category = "Web Technologies",
        IconClass = "devicon-wordpress-plain colored"
    }
};

    public List<ExperienceItem> GetExperience() => new()
    {
        new()
        {
            Title = "International Research Intern",
            Organization = "Institute of Technology and Business, Czech Republic",
            DateRange = "May 2026 - July 2026",
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
