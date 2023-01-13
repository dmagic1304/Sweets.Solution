using Microsoft.AspNetCore.Mvc;
using Sweets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Sweets.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetsContext _db;

    public HomeController(SweetsContext db)
      {        
        _db = db;
      }
    
    public ActionResult Index()
    {      
      return View();
    }


  }
}