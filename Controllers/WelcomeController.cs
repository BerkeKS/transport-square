using Microsoft.AspNetCore.Mvc;
using Transport_Square.Models;
using Transport_Square.Controllers;
using Transport_Square.Data;

namespace Transport_Square.Controllers;

public class WelcomeController : Controller{

    private readonly TransportSquareDbContext _db;

    public WelcomeController(TransportSquareDbContext db)
    {
        _db = db;
    }
    
    //public UserList userList = new UserList();

    //GET-Create
    public IActionResult Index(){
        IEnumerable<UserViewModel> users = _db.Users;
        return View(users);
    }
}