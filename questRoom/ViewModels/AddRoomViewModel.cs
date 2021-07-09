using questRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace questRoom.ViewModels
{
    public class AddRoomViewModel
    {
        public List<HttpPostedFileBase> GalleryImageData { get; set; }
        public HttpPostedFileBase File { get; set; }
        public Room room { get; set; }
    }
}