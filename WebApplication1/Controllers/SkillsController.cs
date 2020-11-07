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


            return Content (html, "text/html");
        }

        [HttpGet]
        public IActionResult Form()
        {
            string html1 = 
                "<form method = 'post' action = '/skills/form'>" +
                "<label><b>Date</b></label><br>" +
                "<input type='date' name = 'date' value = 'date'/>" +
                "<fieldset>" +
                "<legend> JavaScript </legend>" +
                "<p>" +
                "<label>Select Level </label>" +
                "<select id = 'js_list'>" +
                "<option value = '1'>Foundational</option>" +
                "<option value = '2'>Intermediate</option>" +
                "<option value = '3'>Advanced</option>" +
                "</select>" +
                "</p>" +
                "</fieldset>" +
                "<br>" +
                "<fieldset>" +
                "<legend> HTML </legend>" +
                "<p>" +
                "<label>Select Level </label>" +
                "<select id = 'html_list'>" +
                "<option value = '1'>Foundational</option>" +
                "<option value = '2'>Intermediate</option>" +
                "<option value = '3'>Advanced</option>" +
                "</select>" +
                "</p>" +
                "</fieldset>" +
                "<br>" +
                "<fieldset>" +
                "<legend> Angular </legend>" +
                "<p>" +
                "<label>Select Level </label>" +
                "<select id = 'angular_list'>" +
                "<option value = '1'>Foundational</option>" +
                "<option value = '2'>Intermediate</option>" +
                "<option value = '3'>Advanced</option>" +
                "</select>" +
                "</p>" +
                "</fieldset>" +
                "</form>";

            return Content(html1, "text/html");
        }
    }
}
