using EFFCOMM_SA_challenge.ControllersLayer;
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
    public partial class NewSecurityForm : Form
    {
        private Controller controller;
        public NewSecurityForm(Controller controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        private void addSec_Click(object sender, EventArgs e)
        {
            Security sec = new Security();
            sec.securityID = (int)id2.Value;
            sec.securityName = name2.Text;
            sec.securityPrice = (int)price.Value;
            try
            {
                controller.addSecurity(sec);
                MessageBox.Show("New Security added.", "Successs");
            }
            catch (DatabaseException modelException)
            {
                MessageBox.Show(modelException.error);
            }
        }

        private void NewSecurityForm_Load(object sender, EventArgs e)
        {

        }

        private void id2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void price_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modelName_Click(object sender, EventArgs e)
        {

        }

        private void modelID_Click(object sender, EventArgs e)
        {

        }
    }
}
