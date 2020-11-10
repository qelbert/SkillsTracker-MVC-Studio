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
            //[Route("Skillllllzzzz")]

            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Gettin' it Done, One Skill at-a-Time</h2>" +
                "<ol>" +
                "<li>JavaScript</li>" +
                "<li>HTML</li>" +
                "<li>Angular</li>" +
                "</ol>";


            return Content(html, "text/html");
        }

        [HttpGet]
        public IActionResult Form()
        {
            string html1 =
                "<form method = 'post' action = '/skills/form' accept-charset = 'utf - 8'>" +
                "<label><b>Date</b></label><br>" +
                "<input type='date' name ='date' value='date'/>" +
                "<fieldset>" +
                "<legend> JavaScript </legend>" +
                "<p>" +
                "<label>Select Level </label>" +
                "<select name = 'javascript'>" +
                "<option value='Foundational'>Foundational</option>" +
                "<option value='Intermediate'>Intermediate</option>" +
                "<option value='Advanced'>Advanced</option>" +
                "</select>" +
                "</p>" +
                "</fieldset>" +
                "<br>" +
                "<fieldset>" +
                "<legend> HTML </legend>" +
                "<p>" +
                "<label>Select Level </label>" +
                "<select name = 'html'>" +
                "<option value='Foundational'>Foundational</option>" +
                "<option value='Intermediate'>Intermediate</option>" +
                "<option value='Advanced'>Advanced</option>" +
                "</select>" +
                "</p>" +
                "</fieldset>" +
                "<br>" +
                "<fieldset>" +
                "<legend> Angular </legend>" +
                "<p>" +
                "<label>Select Level </label>" +
                "<select name = 'angular'>" +
                "<option value='Foundational'>Foundational</option>" +
                "<option value='Intermediate'>Intermediate</option>" +
                "<option value='Advanced'>Advanced</option>" +
                "</select>" +
                "</p>" +
                "</fieldset>" +
                "<input type= 'submit' value='Submit'>" +
                "</form>";

            return Content(html1, "text/html");
        }

        [HttpPost("/skills/form")]
        public IActionResult Results(string date, string javascript ="Foundational", string html="Foundational", string angular= "Foundational")
        {
            return Content("<h1>DATE: " + date + "</h1>" + "<br><br><h2> Javascript: " + javascript + "<br>HTML: " + html + "<br>Angular: " + angular + "<h2>", "text/html");
        }
    }
}
