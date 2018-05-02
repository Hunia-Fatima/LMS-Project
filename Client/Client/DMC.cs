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
    public partial class DMC : Form
    {
        public DMC()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
           

            source.DataSource = server.Viewresult(server.loggedInStudent());
            dgvDMC.DataSource = source;

        }

        private void dgvDMC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
