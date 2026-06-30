using Microsoft.AspNetCore.Mvc;
using StudentPortfolio.Models;

namespace StudentPortfolio.Controllers;

public class ContactController : Controller
{
    [HttpGet]
    public IActionResult Index() => View(new ContactForm());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(ContactForm model)
    {
        if (!ModelState.IsValid) return View(model);
        // TODO: Replace this placeholder with an email service or database save.
        TempData["Success"] = "Thank you! Your message has been validated. Connect this form to an email service before publishing.";
        ModelState.Clear();
        return View(new ContactForm());
    }
}
