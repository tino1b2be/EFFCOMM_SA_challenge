namespace EFFCOMM_SA_challenge
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewModel = new System.Windows.Forms.Button();
            this.createModel = new System.Windows.Forms.Button();
            this.listSecurities = new System.Windows.Forms.Button();
            this.listModels = new System.Windows.Forms.Button();
            this.createSecurity = new System.Windows.Forms.Button();
            this.updateModel = new System.Windows.Forms.Button();
            this.updateSecurity = new System.Windows.Forms.Button();
            this.deleteModel = new System.Windows.Forms.Button();
            this.deleteSecurity = new System.Windows.Forms.Button();
            this.addSecurityToModel = new System.Windows.Forms.Button();
            this.deleteSecurityFromModel = new System.Windows.Forms.Button();
            this.updateModelSecurity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewModel
            // 
            this.viewModel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewModel.Location = new System.Drawing.Point(12, 12);
            this.viewModel.Name = "viewModel";
            this.viewModel.Size = new System.Drawing.Size(116, 44);
            this.viewModel.TabIndex = 2;
            this.viewModel.Text = "View a Model";
            this.viewModel.UseVisualStyleBackColor = false;
            this.viewModel.Click += new System.EventHandler(this.viewModel_Click);
            // 
            // createModel
            // 
            this.createModel.Location = new System.Drawing.Point(79, 142);
            this.createModel.Name = "createModel";
            this.createModel.Size = new System.Drawing.Size(116, 23);
            this.createModel.TabIndex = 3;
            this.createModel.Text = "Create new Model";
            this.createModel.UseVisualStyleBackColor = true;
            this.createModel.Click += new System.EventHandler(this.createModel_Click);
            // 
            // listSecurities
            // 
            this.listSecurities.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listSecurities.Location = new System.Drawing.Point(284, 12);
            this.listSecurities.Name = "listSecurities";
            this.listSecurities.Size = new System.Drawing.Size(116, 44);
            this.listSecurities.TabIndex = 4;
            this.listSecurities.Text = "List all Securities";
            this.listSecurities.UseVisualStyleBackColor = false;
            this.listSecurities.Click += new System.EventHandler(this.listSecurities_Click);
            // 
            // listModels
            // 
            this.listModels.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listModels.Location = new System.Drawing.Point(148, 12);
            this.listModels.Name = "listModels";
            this.listModels.Size = new System.Drawing.Size(116, 44);
            this.listModels.TabIndex = 5;
            this.listModels.Text = "List all Models";
            this.listModels.UseVisualStyleBackColor = false;
            this.listModels.Click += new System.EventHandler(this.listModels_Click);
            // 
            // createSecurity
            // 
            this.createSecurity.Location = new System.Drawing.Point(215, 142);
            this.createSecurity.Name = "createSecurity";
            this.createSecurity.Size = new System.Drawing.Size(116, 23);
            this.createSecurity.TabIndex = 6;
            this.createSecurity.Text = "Create new Security";
            this.createSecurity.UseVisualStyleBackColor = true;
            this.createSecurity.Click += new System.EventHandler(this.createSecurity_Click);
            // 
            // updateModel
            // 
            this.updateModel.Location = new System.Drawing.Point(79, 171);
            this.updateModel.Name = "updateModel";
            this.updateModel.Size = new System.Drawing.Size(115, 38);
            this.updateModel.TabIndex = 7;
            this.updateModel.Text = "Update existing Model details";
            this.updateModel.UseVisualStyleBackColor = true;
            this.updateModel.Click += new System.EventHandler(this.updateModel_Click);
            // 
            // updateSecurity
            // 
            this.updateSecurity.Location = new System.Drawing.Point(215, 171);
            this.updateSecurity.Name = "updateSecurity";
            this.updateSecurity.Size = new System.Drawing.Size(116, 38);
            this.updateSecurity.TabIndex = 8;
            this.updateSecurity.Text = "Update Existing Security details";
            this.updateSecurity.UseVisualStyleBackColor = true;
            this.updateSecurity.Click += new System.EventHandler(this.updateSecurity_Click);
            // 
            // deleteModel
            // 
            this.deleteModel.Location = new System.Drawing.Point(80, 215);
            this.deleteModel.Name = "deleteModel";
            this.deleteModel.Size = new System.Drawing.Size(115, 23);
            this.deleteModel.TabIndex = 9;
            this.deleteModel.Text = "Delete Model";
            this.deleteModel.UseVisualStyleBackColor = true;
            this.deleteModel.Click += new System.EventHandler(this.deleteModel_Click);
            // 
            // deleteSecurity
            // 
            this.deleteSecurity.Location = new System.Drawing.Point(215, 214);
            this.deleteSecurity.Name = "deleteSecurity";
            this.deleteSecurity.Size = new System.Drawing.Size(116, 23);
            this.deleteSecurity.TabIndex = 10;
            this.deleteSecurity.Text = "Delete Security";
            this.deleteSecurity.UseVisualStyleBackColor = true;
            this.deleteSecurity.Click += new System.EventHandler(this.deleteSecurity_Click);
            // 
            // addSecurityToModel
            // 
            this.addSecurityToModel.Location = new System.Drawing.Point(13, 77);
            this.addSecurityToModel.Name = "addSecurityToModel";
            this.addSecurityToModel.Size = new System.Drawing.Size(115, 39);
            this.addSecurityToModel.TabIndex = 11;
            this.addSecurityToModel.Text = "Add Security to existing Model";
            this.addSecurityToModel.UseVisualStyleBackColor = true;
            this.addSecurityToModel.Click += new System.EventHandler(this.addSecurityToModel_Click);
            // 
            // deleteSecurityFromModel
            // 
            this.deleteSecurityFromModel.Location = new System.Drawing.Point(148, 77);
            this.deleteSecurityFromModel.Name = "deleteSecurityFromModel";
            this.deleteSecurityFromModel.Size = new System.Drawing.Size(116, 39);
            this.deleteSecurityFromModel.TabIndex = 12;
            this.deleteSecurityFromModel.Text = "Delete Security from existing Model";
            this.deleteSecurityFromModel.UseVisualStyleBackColor = true;
            this.deleteSecurityFromModel.Click += new System.EventHandler(this.deleteSecurityFromModel_Click);
            // 
            // updateModelSecurity
            // 
            this.updateModelSecurity.Location = new System.Drawing.Point(284, 77);
            this.updateModelSecurity.Name = "updateModelSecurity";
            this.updateModelSecurity.Size = new System.Drawing.Size(116, 39);
            this.updateModelSecurity.TabIndex = 13;
            this.updateModelSecurity.Text = "Update Security of existing Model";
            this.updateModelSecurity.UseVisualStyleBackColor = true;
            this.updateModelSecurity.Click += new System.EventHandler(this.updateModelSecurity_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 256);
            this.Controls.Add(this.updateModelSecurity);
            this.Controls.Add(this.deleteSecurityFromModel);
            this.Controls.Add(this.addSecurityToModel);
            this.Controls.Add(this.deleteSecurity);
            this.Controls.Add(this.deleteModel);
            this.Controls.Add(this.updateSecurity);
            this.Controls.Add(this.updateModel);
            this.Controls.Add(this.createSecurity);
            this.Controls.Add(this.listModels);
            this.Controls.Add(this.listSecurities);
            this.Controls.Add(this.createModel);
            this.Controls.Add(this.viewModel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewModel;
        private System.Windows.Forms.Button createModel;
        private System.Windows.Forms.Button listSecurities;
        private System.Windows.Forms.Button listModels;
        private System.Windows.Forms.Button createSecurity;
        private System.Windows.Forms.Button updateModel;
        private System.Windows.Forms.Button updateSecurity;
        private System.Windows.Forms.Button deleteModel;
        private System.Windows.Forms.Button deleteSecurity;
        private System.Windows.Forms.Button addSecurityToModel;
        private System.Windows.Forms.Button deleteSecurityFromModel;
        private System.Windows.Forms.Button updateModelSecurity;
    }
}

