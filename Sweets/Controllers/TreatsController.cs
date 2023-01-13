using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Sweets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;


namespace Sweets.Controllers
{

  
  public class TreatsController : Controller
  {
    private readonly SweetsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TreatsController(UserManager<ApplicationUser> userManager, SweetsContext db)
    {        
        _userManager = userManager;
        _db = db;
    }
        
    public ActionResult Index()
    {
        List<Treat> treats = _db.Treats.ToList();
      
      return View(treats);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Treat treat)
    {      
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");    
    }

   
  }
}