using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace InstaclonePhotogram.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        //Alright, so I think initially I can just have it check the return of the username box initially
        //And if it matches in the database then I can return something saying it worked!
        //Like I could totally just do that in the console

        //Afterwards I can add the password but that should be easy


    }
}