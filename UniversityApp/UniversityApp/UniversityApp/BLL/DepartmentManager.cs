using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.DAL.DAO;
using UniversityApp.DAL.DbGateway;

namespace UniversityApp.BLL
{
    class DepartmentManager
    {
        DepartmentDbGateway aDepartmentDbGateway = new DepartmentDbGateway();
        internal string AddDepartmentToDb(Department aDepartment)
        {
            if (HasDepartment(aDepartment.Code))
            {
                return "Department Allready Exist";
            }
            else
            {
                string alert = aDepartmentDbGateway.AddNewDepartmentToDb(aDepartment);
                return alert;
            }
        }

        private bool HasDepartment(int departmentCode)
        {
            return aDepartmentDbGateway.HasDepartment(departmentCode);
        }

        internal List<Department> GetAllDepartFromDb()
        {
            return aDepartmentDbGateway.GetAllDepartmentFromDB();
        }
    }
}
