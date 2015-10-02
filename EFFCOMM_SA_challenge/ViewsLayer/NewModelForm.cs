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
    public partial class NewModelForm : Form

    {
        private Controller controller;
        public NewModelForm(Controller controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        private void NewModelForm_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.modelID = (int) id.Value;
            model.modelName = name.Text;
            model.modelDesc = descr.Text;
            try
            {
                controller.addModel(model);
                MessageBox.Show("Model " + model.modelID + " has been successfully added.", "Sucess!");
            }
            catch (DatabaseException modelException)
            {
                MessageBox.Show(modelException.error);
            }
        }

        private void id_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void descr_TextChanged(object sender, EventArgs e)
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
