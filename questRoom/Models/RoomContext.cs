using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace questRoom.Models
{
    public class RoomContext:DbContext
    {
        public DbSet<Room> rooms { get; set; }   
        public DbSet<Telephone> telephones { get; set; }   
        public DbSet<Gallery> galleries { get; set; }   
    }
}