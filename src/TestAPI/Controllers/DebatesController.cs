using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("debates")]
    public class DebatesController : Controller
    {
        private List<Debate> debates = new List<Debate>();

        [Route("")]
        public IEnumerable<Debate> Get()
        {
            System.Console.WriteLine("PISS");
            return this.debates;
        }

        [Route("")]
        [HttpPost]
        public Debate Post(Debate debate)
        {
            this.debates.Add(debate);
            return debate;
        }
    }
}