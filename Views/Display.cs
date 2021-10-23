using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalbayogBoardHouseLocator
{

    public class Display
    {
        public List<Room> Rooms { get; set; } = new List<Room>();

        public void Show(List<Room> Lst)
        {
            Rooms.AddRange(Lst.AsEnumerable());
            foreach (var Row in Rooms)
            {
                var SB = new StringBuilder();
                SB.Append("########################");
                SB.Append(string.Format("Room: {0}", Row.Description));
                SB.Append(Environment.NewLine);
                SB.Append(string.Format("Rent: {0}", Row.Rent));
                SB.Append(Environment.NewLine);
                SB.Append(string.Format("Status Info: {0}", Row.Status));
                SB.Append(Environment.NewLine);
                SB.Append("------------------------");
                SB.Append(Environment.NewLine);
                SB.Append(string.Format("Owner: {0}", Row.Owner.Name));
                SB.Append(Environment.NewLine);
                SB.Append(string.Format("Contact: {0}", Row.Owner.Contact));
                SB.Append(Environment.NewLine);
                SB.Append("------------------------");
                SB.Append(Environment.NewLine);
                SB.Append("########################");
                SB.Append(Environment.NewLine);
                SB.Append(string.Format("Barangay: {0}", Row.Location.Barangay));
                SB.Append(Environment.NewLine);
                SB.Append(string.Format("Purok: {0}", Row.Location.Purok));
                SB.Append(Environment.NewLine);
                SB.Append(Environment.NewLine);
                Console.WriteLine(SB.ToString());
            }
        }

        public List<Room> Search(List<Room> Lst, string _Barangay)
        {
            return Lst.Where(Row => Row.Location.Barangay.Equals(_Barangay)).ToList();
        }

    }

}