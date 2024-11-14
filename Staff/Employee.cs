using System;
using System.Collections.Generic;
using System.Linq;

namespace Staff
{
    internal class Employee : EmployeeBase
    {

        public Employee(string name, string jobTitle)
        {
            GenerateId();
            Name = name;
            JobTitle = jobTitle;

        }

        private protected sealed override int GenerateId()
        {
            int newId;

            if (_existingIds.Count == 0) 
            {
                _existingIds = new List<int>();
                newId = 0;
            }
            else
            {
                newId = _existingIds.Max() + 1;
                _existingIds.Add(newId);
            }

            return newId;

        }

        internal protected virtual void GetInfo()
        {
            Console.WriteLine($"Id{this.Id},Name{this.Name}, JobTitle{this.JobTitle}");
        }
    }
}
