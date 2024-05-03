using Microsoft.AspNetCore.Mvc;
using Transport_Square.Models;
using Transport_Square.Controllers;
using Transport_Square.Data;

namespace Transport_Square.Controllers;

public class RegisterController : Controller {

    private readonly TransportSquareDbContext _db;

    public RegisterController(TransportSquareDbContext db)
    {
        _db = db;
    }

    public UserList userList = new UserList();
    public IActionResult Index(){
        //Create a viewmodel here to use in respective cshtml file
        var userViewModel = new UserViewModel();
        return View(userViewModel);
    }

    //POST-Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Register(UserViewModel userViewModel){
        //Static variables have to be used with data type instead of instance name

        if (ModelState.IsValid)
        {
            _db.Users.Add(userViewModel);
            _db.SaveChanges();
            return RedirectToAction("Index", "Welcome");
        }
        return View(userViewModel);
    }
}