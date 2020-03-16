using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootsrapDemoTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootsrapDemoTest.Controllers
{
    public class FriendsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private static List<FriendModel> friends = new List<FriendModel>()
        {
            new FriendModel()
            {
                FriendID = 0,
                Name = "Sandra Jacheva",
                Hometown = "Veles"
            }
        };

        // GET: Friend
        public ActionResult AllFriends()
        {
            return View(friends);
        }

        public ActionResult AddFriend()
        {
            FriendModel model = new FriendModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult AddFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
                return View("AddFriend", model);
            friends.Add(model);
            return RedirectToAction("AllFriends", "Friends");
        }

        public ActionResult EditFriend(int id)
        {
            try
            {
                var model = friends.ElementAt(id);
                return View(model);
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", "Home");
            }
            
        }

        [HttpPost]
        public ActionResult EditFriend(FriendModel model)
        {
            if (!ModelState.IsValid)
                return View("EditFriend", model);
            friends.RemoveAt(model.ID);
            friends.Insert(model.ID, model);
            return RedirectToAction("AllFriends", "Friend");
        }

        public ActionResult DeleteFriend(int id)
        {
            friends.RemoveAt(id);
            return RedirectToAction("AllFriends", "Friends");
        }
    }
}