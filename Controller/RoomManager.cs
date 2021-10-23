using System.Collections.Generic;

namespace CalbayogBoardHouseLocator
{

    public class RoomManager
    {
        public List<Room> Rooms { get; set; } = new List<Room>();

        public void AddRoom(Room Model)
        {
            Rooms.Add(Model);
        }

    }

}