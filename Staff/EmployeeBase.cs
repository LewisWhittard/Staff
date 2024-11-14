using System.Collections.Generic;

namespace Staff
{
    public class EmployeeBase
    {
        private protected readonly int _iD;
        private protected string _jobTitle;
        private protected string _name;
        private protected static List<int> _existingIds;

        internal protected int Id
        {
            get { return this._iD; }
        }

        internal protected string JobTitle 
        { get { return this._jobTitle; } 
          private set { this._jobTitle = value; }
        }

        internal protected string Name
        {
            get { return this._name; }
            private set { this._name = value; }
        }

        private protected virtual void GenerateId()
        {
            throw new System.Exception("Developer should not be using base)");
        }

        private protected virtual void GetInfo()
        {
            throw new System.Exception("Developer should not be using base)");
        }
    }
}
