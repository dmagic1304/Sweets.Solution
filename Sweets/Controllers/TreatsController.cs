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


namespace RecipeBox.Controllers
{

  [Authorize]
  public class SweetsController : Controller
  {
    private readonly SweetsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public SweetsController(UserManager<ApplicationUser> userManager, SweetsContext db)
    {        
        _userManager = userManager;
        _db = db;
    }
        
    public async Task<ActionResult> Index()
    {/
      
      List<Recipe> recipeList = new List<Recipe> {};
      string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      if (userId != null)
      {
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        recipeList = _db.Recipes.Where(entry => entry.User.Id == currentUser.Id).ToList();
      }
      return View(recipeList);
    }

   
  }
}