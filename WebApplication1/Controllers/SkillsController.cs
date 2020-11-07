using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            // GET: /<controller>
            string html1 = "<h1>Skills Tracker</h1>" +
                "<h2>Gettin' it Done, One Skill at-a-Time</h2>" +
                "<ol>" +
                "<li>JavaScript</li>" +
                "<li>HTML</li>" +
                "<li>Angular</li>" +
                "</ol>";


            return Content (html1, "text/html");
        }
    }
}
