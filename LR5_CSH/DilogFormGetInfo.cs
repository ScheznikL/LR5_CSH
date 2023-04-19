using System;
using LR5_CSH.Models;
using System.Windows.Forms;

namespace LR5_CSH
{
    public partial class DilogFormGetInfo : Form
    {
        private BindingSource _source;
        public DilogFormGetInfo()
        {
            InitializeComponent();
            dGVDepartments.AutoGenerateColumns = false;
            _source = new BindingSource();
            _source.DataSource = Factory.DepartmentsList;
            dGVDepartments.DataSource = _source;
        }
        public void UpdateDataGridView()
        {
            if (dGVDepartments.InvokeRequired)
            {
                dGVDepartments.Invoke(new Action(UpdateDataGridView));
            }
            else
            {
                _source.ResetBindings(true);
                dGVDepartments.Update();                
            }
        }
    }
}
