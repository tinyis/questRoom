using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace questRoom.Models
{
    public class Telephone
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public int? RoomId { get; set; }
        public Room Room { get; set; }
    }
}