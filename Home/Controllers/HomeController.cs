using Microsoft.AspNetCore.Mvc;

namespace Home.Controllers;

[Route("api/users")]
public class UsersController : ControllerBase
{

    [HttpGet(Name = "users")]
    public IActionResult Get()
    {
        var users = new List<User>();

        users.Add(new User("Yusuf", "Küçükateş"));
       

        return Ok(users);
    }
}


public record User(string Name, string LastName);