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
    /// Windows for to handle Adding a new security to an existing form
    /// </summary>
    public partial class AddSecurityToModelForm : Form
    {
        private Controller controller;

        public AddSecurityToModelForm(Controller controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        /// <summary>
        /// Listener to add a security to a form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ModelSecurity modSec = new ModelSecurity((int)modID.Value, (int)secID.Value, (int)perc.Value);
            try
            {
                controller.addSecToModel(modSec);
                MessageBox.Show("Security successfully added to the model.",
                    "Success!", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (DatabaseException err) // catch any databse erros
            {
               MessageBox.Show(err.error, 
                   "Error!",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }
    }
}
