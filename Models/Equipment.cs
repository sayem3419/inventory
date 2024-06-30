using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventory.Models
{
    public class Equipment
    {
        public int Equipmentid { get; set; }
        public string Name { get; set; }
        public int count { get; set; }
        public DateTime EntryDate { get; set; }
        public Member Member { get; set; }

        public Equipment()
        {
            Member = new Member();
        }
        public static List<Equipment> ListEquipment()
        {
            List<Equipment> list = new List<Equipment>();
            for (int i = 1; i <= 30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop " + i.ToString();
                equipment.count = i * 5; ;
                equipment.EntryDate = DateTime.Now.Date;
                list.Add(equipment);
            }

            return list;

        }
        public static List<Equipment> ListAssignedEquipment()
        {
            List<Equipment> list = new List<Equipment>();
            for (int i = 1; i <= 30; i++)
            {
                Equipment equipment = new Equipment();
                equipment.Name = "Laptop " + i.ToString();
                equipment.count = i * 5; ;
                equipment.EntryDate = DateTime.Now.Date;

                equipment.Member.MemberName = "Member " + i.ToString();
                equipment.Member.MemberDesignation = "SSE";
                equipment.Member.MobileNumber = "1235656";

                list.Add(equipment);
            }

            return list;

        }
    }
}