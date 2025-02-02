using BLL.Services;
using System.Net.Http;
using System.Net;
using System.Web.Http;
using BLL.DTOs;
using static BLL.Services.UserService;

public class AuthController : ApiController
{
   public UserService _userService = new UserService();




    [HttpPost]
    [Route("api/auth/login")]
    public IHttpActionResult Login([FromBody] LoginRequest request)    {
        if (request == null || string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Password))
            return BadRequest("Invalid username or password.");

        var isValid = _userService.ValidateUser(request.Username, request.Password);

        if (!isValid)
            return Unauthorized();

        return Ok("Login successful");
    }

    [HttpPost]
    [Route("api/auth/logout")]
    public HttpResponseMessage Logout()
    {
        var data = AuthService.Logout();
        if (data)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Logout successful.");
        }
        return Request.CreateResponse(HttpStatusCode.NotFound, "Logout failed.");
    }
}

public class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }
}