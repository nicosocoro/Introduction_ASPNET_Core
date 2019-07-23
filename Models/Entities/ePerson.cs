using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NET_Core_Introduction.Models.Entities
{
    public abstract class ePerson
    {
        [Required]
        public int ID { get; set; }
        [MaxLength(45)]
        public string Name { get; set; }
        [MaxLength(45)]
        public string LastName { get; set; }
        public string CompleteName
        {
            get
            {
                bool b_name = string.IsNullOrEmpty(Name);
                bool b_lastname = string.IsNullOrEmpty(LastName);

                if (b_name && b_lastname)
                    return string.Empty;

                if (b_name)
                    return LastName;

                if (b_lastname)
                    return Name;

                return LastName + ", " + Name;
            }
        }
    }
}
