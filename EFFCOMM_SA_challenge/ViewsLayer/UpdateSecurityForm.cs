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
    /// <summary>
    /// Windows Form to handle updating of existing securities.
    /// </summary>
    public partial class UpdateSecurityForm : Form
    {
        private Controller controller;        

        /// <summary>
        /// Methdo to update an existing security.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSec_Click(object sender, EventArgs e)
        {
            Security sec = new Security();
            sec.securityID = (int)id2.Value;
            sec.securityName = name2.Text;
            sec.securityPrice = (int)price.Value;
            try
            {
                controller.updateSecurity(sec);
                MessageBox.Show("Security Successfully deleted.",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            catch (DatabaseException err)
            {
                MessageBox.Show(err.error,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
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
