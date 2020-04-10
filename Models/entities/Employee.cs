using System;
using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models.entities
{
    public class Employee
    {
        [Required]
        [Range(1,100000000)]
        public int Id { set; get; }
        
        [Required]
        public string Name { set; get; }
        public DateTime Dob { set; get; }
        
        [Required]
        public Role Role { set; get; }
        public Address Address { set; get; }
    }
}