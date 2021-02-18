using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingdomHearts.Models
{
    public class OrgUtils
    {
        OrganizationContext db;

        public OrgUtils()
        {
            db = new OrganizationContext();
            db.Database.EnsureCreated();
            if (db.Organization13.Count() == 0)
            {
                SeedDB();
            }
        }

        private void SeedDB()
        {
            Organization13Entry org1 = new Organization13Entry() { Name = "Xemnas", Weapon = "Etheral Blades" };
            Organization13Entry org2 = new Organization13Entry() { Name = "Xigbar", Weapon = "Arrowguns" };
            Organization13Entry org3 = new Organization13Entry() { Name = "Xaldin", Weapon = "Lances" };
            Organization13Entry org4 = new Organization13Entry() { Name = "Vexen", Weapon = "Sheild" };
            Organization13Entry org5 = new Organization13Entry() { Name = "Lexaeus", Weapon = "Tomahawk" };
            Organization13Entry org6 = new Organization13Entry() { Name = "Zexion", Weapon = "Illusion" };

            db.Add(org1);
            db.Add(org2);
            db.Add(org3);
            db.Add(org4);
            db.Add(org5);
            db.Add(org6);

            db.SaveChanges();
        }

        public void Add(Organization13Entry entry)
        {
            db.Organization13.Add(entry);

            db.SaveChanges();       
            
        }

        public void Remove(Organization13Entry entry)
        {
            var member = db.Organization13.Find(entry.Rank);
            if (member != null)
            {
                db.Organization13.Remove(member);

                db.SaveChanges();
            }
        }

        public void Update(Organization13Entry entry)
        {
            var member = db.Organization13.Find(entry.Rank);
            if (member != null)
            {
                member.Name = entry.Name;
                member.Weapon = entry.Weapon;

                db.SaveChanges();
            }
        }

        public List<Organization13Entry> QueryAll()
        {
            return db.Organization13.ToList();
        }

    }
}
