using KingdomHearts.Models;
using System;
using System.Collections.Generic;

namespace KingdomHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            OrgUtils org = new OrgUtils();
            ListAllMembers(org);


            Organization13Entry updatemember = new Organization13Entry()
            {
                Rank = 6,
                Name = "Zexion",
                Weapon = "Illusion"
            };
            org.Update(updatemember);
            Console.WriteLine("After Update of Member:");
            ListAllMembers(org);

            Organization13Entry newmember = new Organization13Entry()
            {
                Name = "Axel",
                Weapon = "Chakrams",
                TrueName = "Lea"
            };
            org.Add(newmember);
            Console.WriteLine("After Adding New Member: ");
            ListAllMembers(org);

            //Organization13Entry removemember = new Organization13Entry()
            //{
            //    Rank = 8,
            //    Name = "Saix",
            //    Weapon = "Claymore"
            //};
            //org.Remove(removemember);
            //Console.WriteLine("After Removing extra Member:");
            //ListAllMembers(org);

        }

        private static void ListAllMembers(OrgUtils org)
        {
            List<Organization13Entry> Org13 = org.QueryAll();

            Console.WriteLine("Query All: ");
            if (Org13.Count > 0)
            {
                foreach (Organization13Entry s in Org13)
                {
                    Console.WriteLine(s.ToString());
                }
            }
            else
            {
                Console.WriteLine("QueryAll() found no records.");
            }
            Console.WriteLine();
        }
    }
}
