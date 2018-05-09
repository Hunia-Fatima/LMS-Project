﻿using System;
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
    public partial class Student_Chat : Form
    {
        public Student_Chat()
        {
            InitializeComponent();
            BindingSource source = new BindingSource();
            server.Service1 server = new server.Service1();
            if (server.getLoggedInTeacher() != null)
            {
                source.DataSource = server.getLoggedInTeacher();
                DGVteachers.DataSource = source;
                DGVteachers.Columns[0].Visible = false;
                DGVteachers.Columns[1].Visible = false;
                DGVteachers.Columns[5].Visible = false;
                DGVteachers.Columns[6].Visible = false;
            }
        }

        private void Student_Chat_Load(object sender, EventArgs e)
        {

        }

        private void cmdStConvo_Click(object sender, EventArgs e)
        {
            ChatwithStudent form = new ChatwithStudent();
            form.Show();
            ChatWithTeacher form1 = new ChatWithTeacher();
            form1.Show();
            this.Hide();
        }
    }
}