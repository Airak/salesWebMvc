using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        
        [Display(Name="Birth Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
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
