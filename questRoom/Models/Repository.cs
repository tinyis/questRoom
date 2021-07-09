using questRoom.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace questRoom.Models
{
    public class Repository:IRepository
    {
        List<Room> rooms = null;
        int counter = 2;

        public Repository()
        {
            rooms = new List<Room>();

            rooms.Add(new Room
            {
                Id = 1,
                Title = "DIAMOND HEIST",
                Time = 60,
                Address = "St. Louis, MO 63102",
                Description =
                "The largest diamond in the world is almost in your reach. Do you have what " +
                "it takes to grab the " +
                "treasure and get out before the police arrive in this heist escape room?" +
                "Being a person of(devious) action, you’ve pulled together a team of the best " +
                "thieves around.You have a plan,and it’s time to pull off the biggest diamond heist " +
                "in history in this heist escape room! Working with your team of 2 - 10 crooks,you have " +
                "60 heart - pumping minutes " +
                "to get the diamond before the police arrive.Execute the plan flawlessly,and you’ll be rich beyond" +
                " your wildest dreams.Fail,and you’ll all be spending the rest of your life in jail.",
                Telephones = new List<string> { "314-690-3356" },
                Email = "info@mastermindroomescape.com",
                Rating = 5,
                MinPlayers = 2,
                MaxPlayers = 10,
                MinAge = 9,
                DifficultyLevel = 3,
                FearLevel = 1,
                MainPicture = "the-heist-movie-poster.png",
                Gallery = new List<string> { "unnamed.jpg", "5884ad28c361883f468b45bd.jpg" }
            });

            rooms.Add(new Room
            {
                Id = 2,
                Title = "ESCAPE ROOM HARRY POTTER: TRAVEL TO NEVERLAND",
                Time = 75,
                Address = " Kyiv, Shevchenko lane 4",
                Description =
               "A millennium after the founding of the school of magic, an irreparable transition portal " +
               "happened on platform 9 3/4 began to work unilaterally and sends everyone passing through " +
               "it to Neverland. Everyone who left the magical world could no longer return, and the wizards' " +
               "magic wands disappeared during the transition. So gradually, all living inhabitants left the " +
               "magical world, and it became completely different - it was empty, faded and could collapse.And only " +
               "an ordinary person is able to carry a magic wand upon transition.You have the opportunity to return " +
               "to the old days of Hogwarts to receive the title of Wizard, for this you need to find and deliver the " +
               "magic wand to Albus Dumbledore, who is also located in Neverland.Now the fate of the whole magical world " +
               "is only in your hands.Do you have time to go to the end to save the magical world.Hurry up, there’s not " +
               "much time left.",
                Telephones = new List<string> { "0800211950", "+380683682128" },
                Email = "tinyis97@gmail.com",
                Rating = 5,
                MinPlayers = 2,
                MaxPlayers = 5,
                MinAge = 14,
                DifficultyLevel = 3,
                FearLevel = 1,
                MainPicture = "0_JS123386494.jpg",
                Gallery = new List<string> { "xdGjbnfu.jpg", "B6aNHbOe.png", "slide1.jpg" }
            });
        }

        public void AddRoom(Room room)
        {
            counter++;

            Room newRoom = new Room
            {
                Id = counter,
                Address = room.Address,
                Description = room.Description,
                DifficultyLevel = room.DifficultyLevel,
                Email = room.Email,
                FearLevel = room.FearLevel,
                Gallery = room.Gallery,
                MainPicture = room.MainPicture,
                MaxPlayers = room.MaxPlayers,
                MinAge = room.MinAge,
                MinPlayers = room.MinPlayers,
                Rating = room.Rating,
                Telephones = room.Telephones,
                Time = room.Time,
                Title = room.Title
            };

            rooms.Add(newRoom);
        }

        public void DeleteGalleryPic(int idRoom, int indexPic)
        {
            Room room = rooms.FirstOrDefault(r => r.Id == idRoom);
            room.Gallery.RemoveAt(indexPic);
        }

        public void DeleteLogo(int idRoom)
        {
            Room room = rooms.FirstOrDefault(r => r.Id == idRoom);
            room.MainPicture = "";     
        }

        public void DeletePhone(int idRoom, int indexPhone)
        {
            Room room = rooms.FirstOrDefault(r => r.Id == idRoom);
            room.Telephones.RemoveAt(indexPhone);
        }

        public void DeleteRoom(int idRoom)
        {
            rooms.Remove(rooms.FirstOrDefault(n => n.Id == idRoom));
            counter--;
        }

        public void EditRoom(Room newRoom)
        {
            Room room = rooms.FirstOrDefault(r => r.Id == newRoom.Id);
            room.FearLevel = newRoom.FearLevel;
            room.Address = newRoom.Description;
            room.DifficultyLevel = newRoom.DifficultyLevel;
            room.Email = newRoom.Email;
            room.MaxPlayers = newRoom.MaxPlayers;
            room.MinPlayers = newRoom.MinPlayers;
            room.Rating = newRoom.Rating;
            room.Time = newRoom.Time;
            room.Title = newRoom.Title;
            room.Description = newRoom.Description;
            room.MinAge = newRoom.MinAge;
            
            if(newRoom.MainPicture!=null)
            room.MainPicture = newRoom.MainPicture;

              foreach (var item in newRoom.Telephones)
                {
                    if (item != "")
                        room.Telephones.Add(item);
                }
            
            
            foreach (var item in newRoom.Gallery)
            {
                room.Gallery.Add(item);
            }
        }

        public List<Room> GetAllRooms()
        {
            return rooms;
        }

        public Room GetRoom(int idRoom)
        {
            return rooms.FirstOrDefault(i => i.Id == idRoom);
        }
    }
}