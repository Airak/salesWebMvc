using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models.ViewModels
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; }

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
