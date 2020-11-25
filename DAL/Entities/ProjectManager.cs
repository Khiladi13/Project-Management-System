using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProjectManager
    {
        public static List<EmpoyeeDTO> GetAllProjectManager()
        {
            using (PMSEntities _db = new PMSEntities())
            {
                //int role = (int)ProjectManagementSystem.Role.ProjectManager;
                var a = _db.Employees.Where(x => x.Role == 1).ToList();
                var projMangers = _db.Employees.Where(x => x.Role == 1).Select(x => new EmpoyeeDTO
                {

                    EmployeeId = x.EmployeeId,
                    FullName = $"{x.FirstName} {x.LastName}"
                }).ToList();

                return projMangers;

                //return _db.Employees.Where(x => x.Role == (int)ProjectManagementSystem.Role.ProjectManager).Select(x => new EmpoyeeDTO
                //{

                //    EmployeeId = x.EmployeeId,
                //    FullName = $"{x.FirstName} {x.LastName}"
                //}).ToList();
            }
        }
    }
}
