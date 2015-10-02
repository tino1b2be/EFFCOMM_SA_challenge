using EFFCOMM_SA_challenge.ControllersLayer;
using EFFCOMM_SA_challenge.ViewsLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFFCOMM_SA_challenge
{
    /// <summary>
    /// Main Windows for the system GUI
    /// </summary>
    public partial class MainForm : Form
    {
        private Controller controller; // controller to be used in the program
        public MainForm()
        {
            InitializeComponent();
            controller = new Controller();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method to launch a form to diplay a chosen model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewModel_Click(object sender, EventArgs e)
        {
            ViewModelForm form = new ViewModelForm(controller);
            form.Show();
        }

        /// <summary>
        /// Method to call form to create a new model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createModel_Click(object sender, EventArgs e)
        {
            NewModelForm newModelForm = new NewModelForm(controller);
            newModelForm.Show();
        }

        /// <summary>
        /// Method to create a security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createSecurity_Click(object sender, EventArgs e)
        {
            NewSecurityForm form = new NewSecurityForm(controller);
            form.Show();
        }

        /// <summary>
        /// Method that calls the form to list the Securities
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listSecurities_Click(object sender, EventArgs e)
        {
            ListForm list = new ListForm(controller,"s");
            list.Show();
        }

        /// <summary>
        /// Method to launch form that lists the models
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listModels_Click(object sender, EventArgs e)
        {
            ListForm list = new ListForm(controller,"M");
            list.Show();
        }

        /// <summary>
        /// Method to add a security to an existing model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addSecurityToModel_Click(object sender, EventArgs e)
        {
            AddSecurityToModelForm form = new AddSecurityToModelForm(controller);
            form.Show();
        }

        /// <summary>
        /// Method to delete a security from a model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSecurityFromModel_Click(object sender, EventArgs e)
        {
            DeleteSecurityFromModelForm form = new DeleteSecurityFromModelForm(controller);
            form.Show();
        }

        /// <summary>
        /// Method to update an existing model-security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateModelSecurity_Click(object sender, EventArgs e)
        {
            UpdateModelSecurityForm form = new UpdateModelSecurityForm(controller);
            form.Show();
        }

        /// <summary>
        /// Method to upate a model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateModel_Click(object sender, EventArgs e)
        {
            UpdateModelForm form = new UpdateModelForm(controller);
            form.Show();
        }

        /// <summary>
        /// Method to update a security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateSecurity_Click(object sender, EventArgs e)
        {
            UpdateSecurityForm form = new UpdateSecurityForm(controller);
            form.Show();
        }

        /// <summary>
        /// method to delete a model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteModel_Click(object sender, EventArgs e)
        {
            DeleteModelForm form = new DeleteModelForm(controller);
            form.Show();
        }

        /// <summary>
        ///  method to delete a security
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteSecurity_Click(object sender, EventArgs e)
        {
            DeleteSecurityForm form = new DeleteSecurityForm(controller);
            form.Show();
        }
    }
}
