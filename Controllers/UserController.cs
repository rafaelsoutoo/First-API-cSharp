using Microsoft.AspNetCore.Mvc;
using TodoApi.Communication.Requests;
using TodoApi.Communication.Responses;


namespace TodoApi.Controllers;

[Route("api/[controller]")] 
[ApiController]
public class UserController : ControllerBase
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

        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUserJson request)
            {
                var response = new ResponseRegisterUserJson
                {
                    Id = 1,
                    UserName = request.Name,
                };
                return Created(string.Empty, response);
            }
    }