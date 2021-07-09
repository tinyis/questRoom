using questRoom.Interfaces;
using questRoom.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace questRoom.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        IRepository repository = null;

        public AdminController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult AddRoomForm()
        {
            AddRoomViewModel vm = new AddRoomViewModel() { room = new Models.Room() };
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddRoom(AddRoomViewModel viewModel)
        {
            string fileName = Path.GetFileName(viewModel.File.FileName);
            string path = Path.Combine(Server.MapPath("~/Images"), fileName);
            viewModel.File.SaveAs(path);
            viewModel.room.MainPicture = fileName;
      
            if(viewModel.GalleryImageData!=null)
            {
                foreach (HttpPostedFileBase item in viewModel.GalleryImageData)
                {
                    if (item != null)
                    {
                        string fileName1 = Path.GetFileName(item.FileName);
                        string path1 = Path.Combine(Server.MapPath("~/Images"), fileName1);
                        item.SaveAs(path1);
                        viewModel.room.Gallery.Add(fileName1);

                    }
                }
            }

            repository.AddRoom(viewModel.room);

            return RedirectToAction("Index", "Home", new { area = ""});
        }

        public ActionResult ShowEdit()
        {
            return View(repository.GetAllRooms());
        }

        [HttpGet]
        public ActionResult DeleteRoom(int idRoom)
        {
            repository.DeleteRoom(idRoom);
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        [HttpGet]
        public ActionResult EditRoom(int idRoom)
        {
            AddRoomViewModel vm = new AddRoomViewModel() { room = repository.GetRoom(idRoom) };
            return View(vm);
        }

        [HttpPost]
        public ActionResult EditRoomReady(AddRoomViewModel viewModel)
        {
            if(viewModel.File!=null)
            {
                string fileName = Path.GetFileName(viewModel.File.FileName);
                string path = Path.Combine(Server.MapPath("~/Images"), fileName);
                viewModel.File.SaveAs(path);
                viewModel.room.MainPicture = fileName;
            }


            if (viewModel.GalleryImageData != null)
            {
                foreach (HttpPostedFileBase item in viewModel.GalleryImageData)
                {
                    if(item!=null)
                    {
                        string fileName1 = Path.GetFileName(item.FileName);
                        string path1 = Path.Combine(Server.MapPath("~/Images"), fileName1);
                        item.SaveAs(path1);
                        viewModel.room.Gallery.Add(fileName1);
                    }
                }
            }

            repository.EditRoom(viewModel.room);

            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public ActionResult DeleteLogo(int idRoom)
        {
            repository.DeleteLogo(idRoom);

            return RedirectToAction("EditRoom", "Admin", new { area = "Admin", idRoom=idRoom });
        } 

        public ActionResult DeleteGalleryPic(int idRoom, int indexPic)
        {
            repository.DeleteGalleryPic(idRoom, indexPic);

            return RedirectToAction("EditRoom", "Admin", new { area = "Admin", idRoom = idRoom });
        }

        public ActionResult DeletePhone(int idRoom, int indexPhone)
        {
            repository.DeletePhone(idRoom, indexPhone);

            return RedirectToAction("EditRoom", "Admin", new { area = "Admin", idRoom = idRoom });
        }
    }
}