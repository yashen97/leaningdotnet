using Microsoft.AspNetCore.Mvc;
using TestWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DatabaseContext db;
        public UserController()
        {
            db= new DatabaseContext();  
        }
       

        // GET: api/<UserController>
        [HttpGet("all")]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            if (User != null)
            {
                return db.Users.Find(id);
            }
            else
                return null;

            
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                db.Users.Add(user);
                db.SaveChanges();

                return StatusCode(StatusCodes.Status201Created,user);
            }
            catch (Exception )
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut]
        public IActionResult Put([FromBody] User user)
        {
             db.Users.Update(user);
            db.SaveChanges();

            return StatusCode(StatusCodes.Status200OK,user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            /*User user = db.Users.Find(id);
            db.Users.Remove(user);*/
            db.Users.Remove(Get(id));
            db.SaveChanges();
            
        }
    }
}
