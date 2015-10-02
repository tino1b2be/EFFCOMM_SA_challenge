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
    public partial class DeleteModelForm : Form
    {
        private Controller controller;

        public DeleteModelForm(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.delModel((int)modID.Value);
                this.Close();
            }
            catch (DatabaseException err) // catch any databse erros
            {
                MessageBox.Show(err.error);
            }
        }
    }
}
