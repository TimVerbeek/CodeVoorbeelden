//using BroodnodigAPI.Data.Repositories;
//using DeSpaakEntity.Data;
//using Microsoft.AspNetCore.Mvc;
//using SharedModels;

//namespace BroodnodigAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        private UserRepository userRepository;
//        public string message = "Not a valid user";

//        public UserController(BroodNodigContext broodNodigContext)
//        {
//            userRepository = new UserRepository(broodNodigContext);
//        }

//        [HttpPost("CreateUser")]
//        public ActionResult CreateUser(User user)
//        {
//            if (user == null)
//            {
//                return BadRequest(message);
//            }

//            userRepository.AddUser(user);

//            return Ok(user);
//        }


//        [HttpPut("EditUser/{id}")]
//        public ActionResult EditUser(User user, Guid id)
//        {
//            var existingUser = userRepository.GetUserById(id);
//            if (existingUser == null)
//            {
//                return BadRequest(message);

//            }
//            if (user == null)
//            {
//                return BadRequest(message);
//            }
//            try
//            {
//                userRepository.UpdateUser(existingUser, user);
//            }
//            catch (Exception ex)
//            {
//                BadRequest(ex.Message);
//            }

//            return Ok();
//        }


//        [HttpDelete("DeleteUser/{id}")]
//        public ActionResult DeleteUser(Guid id)
//        {
//            var user = userRepository.GetUserById(id);
//            if (user == null)
//            {
//                return BadRequest(message);
//            }

//            userRepository.RemoveUser(user);
//            return Ok();

//        }
//        [HttpGet]
//        public ActionResult<User> GetUser(Guid id)
//        {
//            var user = userRepository.GetUserById(id);
//            if (user == null)
//            {
//                return BadRequest(message);
//            }
//            return Ok(user);
//        }

//        [HttpGet("GetAllUsers")]
//        public ActionResult<ICollection<User>> GetAllUsers()
//        {
//            var users = userRepository.GetAllUsers();

//            if (users.Count == 0)
//            {
//                return BadRequest(message);
//            }
//            return Ok(users);
//        }
//        [HttpGet("GetUserByName/{name}")]
//        public ActionResult<ICollection<User>> GetUsersByName(string name)
//        {
//            var users = userRepository.GetUserByName(name);
//            if (users.Count == 0)
//            {
//                return BadRequest(message);
//            }
//            return Ok(users);
//        }












//    }
//}
