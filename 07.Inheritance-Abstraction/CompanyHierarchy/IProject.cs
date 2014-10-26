using System;

namespace CompanyHierarchy
{
    interface IProject
    {
        string name;
        string startDate;
        string details;
        string state;
        string CloseProject();
    }
}
