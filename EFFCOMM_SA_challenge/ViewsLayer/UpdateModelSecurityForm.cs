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
    /// Windows form to handle updating of Model Securities
    /// </summary>
    public partial class UpdateModelSecurityForm : Form
    {
        private Controller controller;
        public UpdateModelSecurityForm(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ModelSecurity modSec = new ModelSecurity((int)modID.Value, (int)secID.Value, (int)perc.Value);
                controller.updateSecInModel(modSec);
                MessageBox.Show("Update successful.",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (DatabaseException err) // catch any databse erros
            {
                MessageBox.Show(err.error,
                      "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
