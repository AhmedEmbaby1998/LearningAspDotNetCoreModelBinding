using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using ModelBinding.Models.entities;

namespace ModelBinding.Models.repositories
{
    public class EmployeesRepo:IRepositories<Employee>
    {
        public Employee this[int id]
        {
            get => _emplyees[id];
            set => Insert(value);
        }

        public IEnumerable<Employee> Objects => _emplyees.Values;

        private Dictionary<int, Employee> _emplyees = new Dictionary<int, Employee>
        {
            [1] = new Employee
            {
                Id=1,
                Name = "John",
                Dob = new DateTime(1980,12,25),
                Role = Role.Admin
            },
            [2] = new Employee
            {
                Id=2,
                Name = "Micheal",
                Dob = new DateTime(1981,5,13),
                Role = Role.Designer
            },
            [3] = new Employee
            {
                Id=3,
                Name = "Rachael",
                Dob = new DateTime(1982,11,25),
                Role = Role.Designer
            },
            [4] = new Employee
            {
                Id=4,
                Name = "Anna",
                Dob = new DateTime(1983,1,20),
                Role = Role.Manager
            }
        };
            
        private void Insert(Employee element)
        {
            if (_emplyees.ContainsKey(element.Id))
            {
                throw new Exception("an Employee with the same Key is Already Existed");
            }

            _emplyees[element.Id] = element;
        }

        public void Delete(int id)
        {
            if (!_emplyees.ContainsKey(id))
            {
                throw new Exception($"there is no such element with the index {id}");
            }

            _emplyees.Remove(id);
        }

        public bool Contains(int id)
        {
            return _emplyees.ContainsKey(id);
        }

        public void Update(Employee element)
        {
            if (!_emplyees.ContainsKey(element.Id))
            {
                throw new Exception($"there is no such element with the index {element.Id}");
            }

            _emplyees[element.Id] = element;
        }
    }
}