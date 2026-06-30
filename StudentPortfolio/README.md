# Student Portfolio - ASP.NET Core MVC

A polished personal portfolio website for a Software Development student using ASP.NET Core MVC, Razor Views, Bootstrap 5, custom CSS, JavaScript filtering, dark/light mode, validation, and reusable components.

## Replace these placeholders
- `YOUR NAME` in `Views/Shared/_Layout.cshtml` and `Views/Home/Index.cshtml`
- Profile photo: replace `wwwroot/images/profile-placeholder.svg`
- Resume: replace `wwwroot/documents/resume-placeholder.pdf`
- GitHub, LinkedIn, email, and location placeholders
- Project details inside `Services/PortfolioService.cs`
- About page biography and coursework in `Views/About/Index.cshtml`

## Run locally
```bash
dotnet restore
dotnet run
```
Then open the localhost URL shown in the terminal.

## Suggested next upgrades
- Connect the contact form to SendGrid, SMTP, or a database.
- Move sample project data into a database.
- Add Identity if you want an admin dashboard to manage portfolio content.
- Add real project screenshots and a professional headshot.
