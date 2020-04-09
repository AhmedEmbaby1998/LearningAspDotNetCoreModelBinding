using System;

namespace ModelBinding.Models.entities
{
    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public DateTime Dob { set; get; }
        
        public Role Role { set; get; }
        public Address Address { set; get; }
    }
}