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
    public partial class DepartmentEntryUI : Form
    {
        public DepartmentEntryUI()
        {
            InitializeComponent();
        }
        DepartmentManager aDepartmentManager = new DepartmentManager();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Department aDepartment = new Department();
            aDepartment.DepartmentTitle = deptTitleTextBox.Text;
            aDepartment.Code = Convert.ToInt32(deptCodeTextBox.Text);
            string alert = aDepartmentManager.AddDepartmentToDb(aDepartment);
            MessageBox.Show(alert);
        }
    }
}
