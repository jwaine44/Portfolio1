using Microsoft.AspNetCore.Mvc;
// change the namespace name to name of your project!
namespace Porfolio1.Controllers;
    public class PortfolioController : Controller
    {
        // for each route this controller is to handle:
        [HttpGet]   // type of request
        [Route("")] // associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }

    }