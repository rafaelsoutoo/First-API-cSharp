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


        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpadateUserProfileJson request)
        {
            return NoContent();

        }


        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();

        }

        [HttpGet]
        [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var response = new List<User>()
            {
                new User {Id = 1, Age = 3, Name = "Rafael"},
                new User {Id = 2, Age = 13, Name = "Rafael2"},
                new User {Id = 3, Age = 23, Name = "Rafael3"},
                new User {Id = 4, Age = 33, Name = "Rafael4"},
            };

            return Ok(response);

        }

        [HttpPut("change-password")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword([FromBody] RequestChangePasswordJson request)
        {
            return NoContent(); 
        }
    }