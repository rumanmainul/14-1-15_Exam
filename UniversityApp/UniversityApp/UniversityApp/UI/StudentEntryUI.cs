using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityApp.BLL;
using UniversityApp.DAL.DAO;

namespace UniversityApp
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
        }
        DepartmentManager aDepartmentManager = new DepartmentManager();
        private void StudentEntryUI_Load(object sender, EventArgs e)
        {
            List<Department> aDepartmentList = new List<Department>();
            aDepartmentList = aDepartmentManager.GetAllDepartFromDb();
            DepatmentComboBox.DataSource = aDepartmentList;
            DepatmentComboBox.ValueMember = "Code";
            DepatmentComboBox.DisplayMember = "DepartmentTitle";
        }
    }
}
