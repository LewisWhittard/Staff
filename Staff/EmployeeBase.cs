using System.Collections.Generic;

namespace Staff
{
    internal abstract class EmployeeBase
    {
        private protected int _iD;
        private protected string _jobTitle;
        private protected string _name;
        private protected static List<int> _existingIds;

        internal protected int Id
        {
            get { return this._iD; }
            private protected set { this._iD = value; }
        }

        internal protected string JobTitle 
        { get { return this._jobTitle; } 
          private protected set { this._jobTitle = value; }
        }

        internal protected string Name
        {
            get { return this._name; }
            private protected set { this._name = value; }
        }

        private protected abstract int GenerateId();

        internal protected abstract void GetInfo();
    }
}
