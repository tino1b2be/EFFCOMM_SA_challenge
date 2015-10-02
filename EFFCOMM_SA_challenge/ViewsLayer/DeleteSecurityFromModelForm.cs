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
    public partial class DeleteSecurityFromModelForm : Form
    {
        private Controller controller;
        public DeleteSecurityFromModelForm(Controller controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.delSecFromModel((int)modID.Value, (int)secID.Value);
                MessageBox.Show("Security has been deleted from the Model",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (DatabaseException err) // catch any databse errros
            {
                MessageBox.Show(err.error, "ERROR!");
            }
        }

        private void DeleteSecurityFromModelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
