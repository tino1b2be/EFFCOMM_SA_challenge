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
    /// Windows form to handle updates of existing models
    /// </summary>
    public partial class UpdateModelForm : Form
    {
        private Controller controller;
        public UpdateModelForm(Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void add_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.modelID = (int)id.Value;
            model.modelName = name.Text;
            model.modelDesc = descr.Text;

            try
            {
                controller.updateModel(model);
                this.Close();
                MessageBox.Show("Model seccessfully updated.",
                    "Success!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (DatabaseException modelException)
            {
                MessageBox.Show(modelException.error,
                      "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
