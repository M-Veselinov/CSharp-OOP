using System;

namespace CompanyHierarchy
{
    class Project : IProject
    {
        public string Name;
        public string StartDate;
        public string Details;
        public string State = "Open";
        public Project(string name,string startDate,string details)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
        }
        public string CloseProject(Project project)
        {
            if (project.State == "Open")
            {
                project.State = "Closed";
            }
            return this.State;
        }
    }
}
