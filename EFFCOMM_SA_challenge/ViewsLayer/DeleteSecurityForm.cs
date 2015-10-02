﻿using EFFCOMM_SA_challenge.ControllersLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFFCOMM_SA_challenge.ViewsLayer
{
    public partial class DeleteSecurityForm : Form
    {
        private Controller controller;
        public DeleteSecurityForm(Controller controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.delSec((int)secID.Value);
                this.Close();
            }
            catch (DatabaseException err) // catch any databse erros
            {
                MessageBox.Show(err.error);
            }
        }
    }
}
