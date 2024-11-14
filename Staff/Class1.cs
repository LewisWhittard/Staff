using System.Collections.Generic;

namespace Staff
{
    internal abstract class EmployeeBase
    {
        private protected readonly int _iD;
        private protected string _jobTitle;
        private protected string _name;
        private protected static List<int> _existingIds;

        internal int Id
        {
            get { return this._iD; }
        }

        internal string JobTitle 
        { get { return this._jobTitle; } 
          private set { this._jobTitle = value; }
        }

        internal string Name
        {
            get { return this._name; }
            private set { this._name = value; }
        }

        public abstract void GenerateId();

        public abstract string GetInfo();
    }
}
