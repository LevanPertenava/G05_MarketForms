using System;
using System.Windows.Forms;
using Market.Repository;
using Market.Models;
using Market.Client.ExtensionMethodForms;
using System.Reflection;

namespace Market.Client
{
    public partial class EmployeesListForm : Form, IListForm
    {
        private readonly EmployeeRepository _employeeRepository;

        private int GetSelectedId() => Convert.ToInt32((Controls[0] as DataGridView).SelectedRows[0].Cells[0].FormattedValue);

        public EmployeesListForm()
        {
            InitializeComponent();
            empDGV.AutoGenerateColumns = false;
            _employeeRepository = new(@"server = DESKTOP-V7759FH\SQLEXPRESS;database=Market;integrated security=true");
            Reload();
        }

        private void empDGV_DoubleClick(object sender, EventArgs e)
        {
            
            GetEditForm().ShowDialog();
        }

        public void Reload()
        {
            empDGV.DataSource = _employeeRepository.Select();
        }

        public void Delete()
        {
            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _employeeRepository.Delete(GetSelectedId());
                Reload();
            }
        }

        public Form GetAddForm()
        {
            return new Add<Employee>(this);
        }

        public Form GetEditForm()
        {
            return new Edit<Employee>(this, GetSelectedId());
        }
    }
}
