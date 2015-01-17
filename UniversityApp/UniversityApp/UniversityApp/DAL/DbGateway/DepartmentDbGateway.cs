using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using EmployeeInfirmationApp.DAL.DBGateway;
using UniversityApp.DAL.DAO;

namespace UniversityApp.DAL.DbGateway
{
    class DepartmentDbGateway
    {
        SqlConnectionManager aConnectionManager = new SqlConnectionManager();
        internal string AddNewDepartmentToDb(Department aDepartment)
        {
            string addDepartment = "INSERT INTO t_department VALUES('" + aDepartment.Code + "', '" +
                                   aDepartment.DepartmentTitle + "')";
            SqlCommand aCommand = new SqlCommand(addDepartment, aConnectionManager.GetConnection());
            int effectedRows = aCommand.ExecuteNonQuery();
            aConnectionManager.CloseConnection();
            if (effectedRows > 0)
            {
                return "Add new Department";
            }
            else
            {
                return "No Department added";
            }
        }

        internal bool HasDepartment(int departmentCode)
        {
            string findDepartment = "SELECT * FROM t_department WHERE code = '" + departmentCode + "'";
            SqlCommand aSqlCommand = new SqlCommand(findDepartment, aConnectionManager.GetConnection());
            SqlDataReader aReader = aSqlCommand.ExecuteReader();
            bool hasCode = aReader.HasRows;
            aConnectionManager.CloseConnection();
            if (hasCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal List<Department> GetAllDepartmentFromDB()
        {
            List<Department> aDepartmentList = new List<Department>();
            string allDepartmentQuery = "SELECT * FROM t_department";
            SqlCommand aCommand = new SqlCommand(allDepartmentQuery, aConnectionManager.GetConnection());
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
              Department aDepartment = new Department();
              aDepartment.Id = Convert.ToInt32(aReader["id"]);
              aDepartment.Code = Convert.ToInt32(aReader["code"]);
                aDepartment.DepartmentTitle = aReader["department_title"].ToString();
                aDepartmentList.Add(aDepartment);
            }
            return aDepartmentList;
        }
    }
}
