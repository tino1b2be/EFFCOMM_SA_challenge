namespace EFFCOMM_SA_challenge.ViewsLayer
{
    partial class UpdateModelForm
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
            this.id = new System.Windows.Forms.NumericUpDown();
            this.add = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.descr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelName = new System.Windows.Forms.Label();
            this.modelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(219, 36);
            this.id.Maximum = new decimal(new int[] {
            10011,
            0,
            0,
            0});
            this.id.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 14;
            this.id.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(133, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 13;
            this.add.Text = "Update Model";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(219, 71);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 12;
            // 
            // descr
            // 
            this.descr.Location = new System.Drawing.Point(219, 108);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(100, 20);
            this.descr.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description of Model";
            // 
            // modelName
            // 
            this.modelName.AutoSize = true;
            this.modelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelName.Location = new System.Drawing.Point(27, 71);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(116, 17);
            this.modelName.TabIndex = 9;
            this.modelName.Text = "Name of Model";
            // 
            // modelID
            // 
            this.modelID.AutoSize = true;
            this.modelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelID.Location = new System.Drawing.Point(27, 36);
            this.modelID.Name = "modelID";
            this.modelID.Size = new System.Drawing.Size(71, 17);
            this.modelID.TabIndex = 8;
            this.modelID.Text = "Model ID";
            // 
            // UpdateModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 190);
            this.Controls.Add(this.id);
            this.Controls.Add(this.add);
            this.Controls.Add(this.name);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelName);
            this.Controls.Add(this.modelID);
            this.Name = "UpdateModelForm";
            this.Text = "UpdateModelForm";
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox descr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modelName;
        private System.Windows.Forms.Label modelID;
    }
}