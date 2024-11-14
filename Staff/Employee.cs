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

        private protected sealed override void GenerateId()
        {
            if (_existingIds.Count == 0) 
            {
                _existingIds = new List<int>();
                _existingIds.Add(0);
            }
            else
            {
                _existingIds.Add((_existingIds.Max() + 1));
            }

        }

        internal protected virtual void GetInfo()
        {
            Console.WriteLine($"Id{this.Id},Name{this.Name}, JobTitle{this.JobTitle}");
        }
    }
}
