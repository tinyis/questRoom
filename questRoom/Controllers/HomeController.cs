using questRoom.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace questRoom.Controllers
{
    public class HomeController : Controller
    {
        IRepository repository = null;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return View(repository.GetAllRooms());
        }

        public ActionResult Details(int idRoom)
        {
            return View(repository.GetRoom(idRoom));
        }
    }
}