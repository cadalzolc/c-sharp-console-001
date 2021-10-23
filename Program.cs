using System;
using System.Collections.Generic;

using CalbayogBoardHouseLocator;

namespace c_sharp_101
{
    class Program
    {
        static void Main(string[] args)
        {

            var Rms1 = new Room()
            {
                Description = "Dandan Room Barato 1",
                Rent = 1000,
                Status = "Available",
                Owner = new Landlord()
                {
                    ID = 1,
                    Name = "Dandan",
                    Contact = "12123123123"
                },
                Location = new Address()
                {
                    City = "Calbayog",
                    Barangay = "Dagum",
                    Purok = "1",
                    House_No = "001",
                    Street = "Rama Extension"
                }
            };

            var Rms2 = new Room()
            {
                Description = "Jane Room Free",
                Rent = 3000,
                Status = "Available",
                Owner = new Landlord()
                {
                    ID = 1,
                    Name = "Jane",
                    Contact = "12123123123"
                },
                Location = new Address()
                {
                    City = "Calbayog",
                    Barangay = "Matobato",
                    Purok = "2",
                    House_No = "001",
                    Street = "Rama Extension"
                }
            };

            var Rms3 = new Room()
            {
                Description = "Narf Events",
                Rent = 2100,
                Status = "Available",
                Owner = new Landlord()
                {
                    ID = 1,
                    Name = "Narf",
                    Contact = "123138322"
                },
                Location = new Address()
                {
                    City = "Calbayog",
                    Barangay = "Carmen",
                    Purok = "5",
                    House_No = "555",
                    Street = "Ice Plant"
                }
            };

            var Mgr = new RoomManager();
            Mgr.AddRoom(Rms1);
            Mgr.AddRoom(Rms2);
            Mgr.AddRoom(Rms3);

            var DS = new Display();
            var RS = DS.Search(Mgr.Rooms, "Matobato");

            DS.Show(RS);

            //DS.Show(Mgr.Rooms);

        }
    }
}