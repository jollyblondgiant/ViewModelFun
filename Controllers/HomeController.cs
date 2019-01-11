using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
       
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()

        {
            Msg message = new Msg();
            message.msg = "And now at last it comes. You will give me the Ring freely! In place of the Dark Lord you will set up a Queen. And I shall not be dark, but beautiful and terrible as the Morning and the Night! Fair as the Sea and the Sun and the Snow upon the Mountain! Dreadful as the Storm and the Lightning! Stronger than the foundations of the earth. All shall love me and despair!";
            
            return View(message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            BunchaNumbers nums = new BunchaNumbers(){
                numbers = new int[] {1,1,2,3,5,8,13}
            };
            
            
            
            return View(nums);
        }
        [HttpGet("users")]
        public IActionResult Users()
        {
            User Sally = new User(){
                FirstName = "Sally",
                LastName = "McCracken"
            };
            User Yana = new User(){
                FirstName = "Yana",
                LastName = "Banana"
            };
            User Bilbo = new User(){
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            

            List<User> users = new List<User>();
            users.Add(Sally);
            users.Add(Bilbo);
            users.Add(Yana);


            return View(users);
        }
        [HttpGet("user")]
        public IActionResult ViewUser()
        {
            
            User Bilbo = new User(){
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            
            return View(Bilbo);
        }
    }
    public class User
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
    }
}
