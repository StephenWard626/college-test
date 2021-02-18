using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KingdomHearts.Models
{
    public class Organization13Entry
    {
        [Key]
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }

        public string Weapon { get; set; }

        public string TrueName { get; set; }

        public override string ToString()
        {
            return string.Format("Rank: {0} \nName: {1} \nWeapon: {2}\n", Rank, Name, Weapon);
            
        }

    }
}
