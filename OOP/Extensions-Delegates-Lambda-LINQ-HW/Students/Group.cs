namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Group
    {
        public Group(int currentGroupNumber, string currentDepartmentName)
        {
            this.GroupNumber = currentGroupNumber;
            this.DepartmentName = currentDepartmentName;
        }

        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
	}
}