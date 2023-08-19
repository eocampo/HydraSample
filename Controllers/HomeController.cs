using Microsoft.AspNetCore.Mvc;
using Hydra.Models;

namespace Hydra.Controllers;

public class HomeController : Controller
{
    public ActionResult Index() {
        var model = new HomeIndexModel();
        model.Message = "Hello, Hydra!";
        return View(model);
    }
}