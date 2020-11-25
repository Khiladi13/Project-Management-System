using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ProjectManagementSystem
{
    public enum Role
    {
        Admin = 1,
        ProjectManager = 2,
        Employee = 3
    }

    public enum ProjectStatus
    {
        New = 1,
        InProgress = 2,
        Completed = 3,
        Testing = 4,
        OnHold = 5,
        Cancelled = 6
    }

    public enum ProjectOperation
    {
        Insert = 0,
        Update = 1,
        Delete = -1
    }

}