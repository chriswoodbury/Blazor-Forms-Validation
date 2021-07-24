using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorFormsValidation.Shared.Models;

namespace BlazorFormsValidation.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly List<string> userNameList = new();

        public StudentController()
        {
            userNameList.Add("chris");
            userNameList.Add("janie");
            userNameList.Add("nugget");
        }

        [HttpPost]
        public IActionResult Post(StudentRegistration registrationData)
        {
            if (userNameList.Contains(registrationData.Username.ToLower()))
            {
                ModelState.AddModelError(nameof(registrationData.Username), "This user name is not available.");
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(ModelState);
            }

        }
    }
}
