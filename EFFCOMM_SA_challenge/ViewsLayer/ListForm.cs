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
    /// <summary>
    /// Windows form for displaying the Models/Securities
    /// </summary>
    public partial class ListForm : Form
    {
        private string type;
        private Controller controller;

        public ListForm(Controller controller, string type)
        {
            InitializeComponent();
            this.type = type;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.controller = controller;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            if (type.StartsWith("M"))   // display models
            {
                displayModels();
            }
            else // display securities
            {
                displaySecurities();
            }
        }

        /// <summary>
        /// Method to list all securities
        /// </summary>
        private void displaySecurities()
        {
            //Clear current List View Control
            listView1.Clear();

            //get list of securities from DB
            Collection<Security> securities = controller.getAllSecurities();

            if (securities == null)
            {
                MessageBox.Show("There are no Securities in the Database",
                    "Attention!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                listView1.Columns.Insert(0, "Security ID", 120, HorizontalAlignment.Left);
                listView1.Columns.Insert(1, "Security Name", 120, HorizontalAlignment.Left);
                listView1.Columns.Insert(2, "Security Price", 120, HorizontalAlignment.Left);

                foreach (Security security in securities)
                {
                    ListViewItem listItem = new ListViewItem();
                    listItem.Text = security.securityID.ToString();
                    listItem.SubItems.Add(security.securityName);
                    listItem.SubItems.Add(security.securityPrice.ToString());

                    listView1.Items.Add(listItem);
                }
            }
        }

        /// <summary>
        /// Method to list all models
        /// </summary>
        private void displayModels()
        {
            //Clear current List View Control
            listView1.Clear();

            //get list of securities from DB
            Collection<Model> models = controller.getAllModels();
            if (models == null)
            {
                MessageBox.Show("There are no Models in the Database",
                    "Attention!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                listView1.Columns.Insert(0, "Model ID", 60, HorizontalAlignment.Left);
                listView1.Columns.Insert(1, "Model Name", 120, HorizontalAlignment.Left);
                listView1.Columns.Insert(2, "Model Description", 440, HorizontalAlignment.Left);

                foreach (Model model in models)
                {
                    ListViewItem listItem = new ListViewItem();
                    listItem.Text = model.modelID.ToString();
                    listItem.SubItems.Add(model.modelName);
                    listItem.SubItems.Add(model.modelDesc);

                    listView1.Items.Add(listItem);
                }
                listView1.Refresh();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
