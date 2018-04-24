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
    public partial class frmRegisterSubject : Form
    {
        public frmRegisterSubject()
        {
            InitializeComponent();
            server.Service1 myservice = new server.Service1();
            BindingSource source = new BindingSource();
            List<server.Subject> s = myservice.getSubjects().ToList();
            source.DataSource = s;
            lblName.Text = myservice.loggedInStudent().Name;
            gvRegisterSubjects.DataSource = source;
        }

        private void gvRegisterUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            server.Service1 myserver = new server.Service1();
            bool is_found = false;
            if (e.ColumnIndex == 0)
            {
                foreach (server.Subject s in myserver.loggedInStudentSubject())
                {
                    if (s == myserver.getSubjects()[e.RowIndex])
                    {
                        //myserver.unregisterSubject(myserver.loggedInStudent(), myserver.getSubjects()[e.RowIndex]);
                        MessageBox.Show("Subject Unregistered");
                        is_found = true;

                    }
                }
                if(!is_found)
                {
                //myserver.registerSubject(myserver.loggedInStudent(),myserver.getSubjects()[e.RowIndex]);
                MessageBox.Show("You are registered in the subject");
                }
            }                              
        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin form = new Admin();
            form.Show(); ;
            this.Hide();
        }
    }
}
