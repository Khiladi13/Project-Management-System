using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProjectOperation
    {
        public static void AddupdateProject(int actionId, Project myproject)
        {
            using (PMSEntities _db = new PMSEntities())
            {
                var projDetails = _db.PMS_Project(actionId, myproject.ProjectId , myproject.ProjectName, myproject.ProjectDescription, myproject.StartDate, myproject.EndDate, myproject.ProjectManagerId, myproject.ProjectStatus, myproject.CreatedBy, myproject.ModifyBy);

            }
        }
    }
}
