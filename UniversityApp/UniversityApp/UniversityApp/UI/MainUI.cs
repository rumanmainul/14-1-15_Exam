using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityApp
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void DepartmentButton_Click(object sender, EventArgs e)
        {
            DepartmentEntryUI aDepartmentEntryUi = new DepartmentEntryUI();
            aDepartmentEntryUi.ShowDialog();
        }

        private void StudentEntryButton_Click(object sender, EventArgs e)
        {
            StudentEntryUI aStudentEntryUi = new StudentEntryUI();
            aStudentEntryUi.ShowDialog();
        }
    }
}
