using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLient
{
    public partial class DMCAdmin : Form
    {
        public DMCAdmin()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            source.DataSource = server.Viewresult(server.loggedInStudent());
            gvAdminDMC.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
