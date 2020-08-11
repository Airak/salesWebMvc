using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId  { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
    
        public Seller()
        {

        }

        public Seller(int id, string email, string Name, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Email = email;
            Name = Name;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
    }
}
