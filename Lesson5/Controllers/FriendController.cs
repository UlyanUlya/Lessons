using Lesson5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson5.Controllers
{
    public class FriendController : Controller
    {
        public IActionResult Index()
        {
            List<Friend> friends = new List<Friend>();
            friends.Add(new Friend { FriendId = 1, FriendName = "Oksancik", Place = "Kyiv" });
            friends.Add(new Friend { FriendId = 2, FriendName = "Margorita", Place = "Kriviy Rih" });
            friends.Add(new Friend { FriendId = 3, FriendName = "Ilonuszka", Place = "Obuchiv" });
            //return View(friends);
            return View();
        }

        public ActionResult Insert()
        {
            return View();
        }

        //Creation
        [HttpPost]
        public ActionResult Insert(Friend friend)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(friend);
        }


        public ActionResult Edit(int id)
        {
            Friend friend = new Friend
            {
                FriendId = id,
                FriendName = "Pablo",
                Place = "Kyiv"
            };
            return View(friend);
        }

        //Editing
        [HttpPost]
        public ActionResult Edit(FormCollection form)
        {
            int friendId = int.Parse(form["FriendId"]);
            string friendName = form["FriendName"];
            string place = form["Place"];

            return RedirectToAction("Index");
        }

        //Deleting
        public ActionResult Delete(int id)
        {
            // Retrieve friend from database
            Friend friend = new Friend { FriendId = id };

            return View(friend);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            // Delete friend from database

            return RedirectToAction("Index");
        }

        [HttpPost]
        public string Hello() => "Hello";

        public string Context()
        {
            return HttpContext.Request.Path;
        }

        [ActionName("Name")]
        public string FriendName(string name, int age) => $"Your friend name is {name} and she's {age} years old";


        /* //Draft
        public IActionResult Index()
        {
            return View();
        }

        public string Index()
        {
            return "it`s me";
        }
        public IActionResult Valid()
        {
            if (!ModelState.IsValid) {return BadRequest(ModelState);}
            return View();
            
        }
        public IActionResult View()
        { 
            return View("View");
        }*/

    }
}
