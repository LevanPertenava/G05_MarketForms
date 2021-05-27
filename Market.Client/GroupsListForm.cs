using Market.Models;
using Market.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Client
{
    public partial class GroupsListForm : Form, IListForm
    {
        private readonly GroupRepository _groupRepository;
        private int _groupId = 0;

        public GroupsListForm()
        {
            InitializeComponent();
            groupsDGV.AutoGenerateColumns = false;
            _groupRepository = new(@"server = DESKTOP-V7759FH\SQLEXPRESS;database=Market;integrated security=true");
        }

        private void GroupListForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void empDGV_DoubleClick(object sender, EventArgs e)
        {
            GetEditForm().ShowDialog();
        }

        private void empDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _groupId = int.Parse((Controls[0] as DataGridView).SelectedRows[0].Cells[0].FormattedValue.ToString());
        }

        public void Reload()
        {
            groupsDGV.DataSource = _groupRepository.Select();
        }

        public void Delete()
        {
            var result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _groupRepository.Delete(_groupId);
                Reload();
            }
        }

        public Form GetAddForm()
        {
            return new Add<Group>(this);
        }

        public Form GetEditForm()
        {
            return new Edit<Group>(this, _groupId);
        }
    }
}
