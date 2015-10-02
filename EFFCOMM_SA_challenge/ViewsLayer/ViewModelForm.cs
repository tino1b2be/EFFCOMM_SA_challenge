using EFFCOMM_SA_challenge.ControllersLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFFCOMM_SA_challenge.ViewsLayer
{
    public partial class ViewModelForm : Form
    {
        private Controller controller;
        public ViewModelForm(Controller controller)
            : base()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displaySecurities();
        }

        /// <summary>
        /// Method to display securities for a given model
        /// </summary>
        private void displaySecurities()
        {
            listView1.Clear();
            listView1.Columns.Insert(0, "Security Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Insert(1, "Percentage", 120, HorizontalAlignment.Left);
            Model model;
            try
            {
                model = controller.getModel((int)id.Value);
            }
            catch (DatabaseException err)
            {
                MessageBox.Show(err.error + " Please try again.",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            textName.Text = model.modelName;
            textDescr.Text = model.modelDesc;
            Collection<ModelSecurity> securities = controller.getSecurities((int)id.Value);
            
            if (securities == null) // display error if there are no securities
            {
                MessageBox.Show("There are no Securities for the Model with ID: \"" + id.Value + "\" in the Database",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            else  // display securities
            {
                foreach (ModelSecurity sec in securities)
                {
                    ListViewItem listItem = new ListViewItem();
                    listItem.Text = sec.securityName;
                    listItem.SubItems.Add(sec.percentage.ToString());

                    listView1.Items.Add(listItem);
                }
                listView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
