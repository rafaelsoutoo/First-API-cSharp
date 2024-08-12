using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[Route("api/[controller]")] 
[ApiController]
public class UsersController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")] // query or path
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)] //mostra o tipo e respostas no swagger
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        
        public IActionResult GetById([FromRoute]int id) // [] É DA ONDE ESSE ID VEM
        {
            var user = new User
            {
                Id = 1,
                Age = 3,
                Name = "Rafael"
            };

            return Ok(user);
        }
    }