using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using API.Entity;

namespace API.Controllers
{
    [ApiController]
    [Route("buggy")]
    public class BuggyController : ControllerBase
    {
        private readonly DataContext _context;

        public BuggyController(DataContext context)
        {
            _context = context;
        }


        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret";
        }

        [HttpGet("server-error")]
        public ActionResult<Movie> GetNotFound()
        {
            var thing = _context.Movies.Find(-1);
            var thingToReturn = thing.ToString();

            return Ok(thingToReturn);
        }

        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("Not a good request");
        }

    }
}