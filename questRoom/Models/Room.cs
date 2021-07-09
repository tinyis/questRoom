using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace questRoom.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int MinAge { get; set; }
        public string Address { get; set; }
        public List<String> Telephones { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }
        public int FearLevel { get; set; }
        public int DifficultyLevel { get; set; }    
        public string MainPicture { get; set; }
        public List<String> Gallery { get; set; }

        public Room()
        {
            Gallery = new List<string>();
            Telephones = new List<string>();
        }
    }
}