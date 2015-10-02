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
    public partial class UpdateSecurityForm : Form
    {
        private Controller controller;        

        private void addSec_Click(object sender, EventArgs e)
        {
            Security sec = new Security();
            sec.securityID = (int)id2.Value;
            sec.securityName = name2.Text;
            sec.securityPrice = (int)price.Value;
            try
            {
                controller.updateSecurity(sec);
                this.Close();
            }
            catch (DatabaseException modelException)
            {
                MessageBox.Show(modelException.error);
            }
        }

        public UpdateSecurityForm(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
