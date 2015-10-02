namespace EFFCOMM_SA_challenge.ViewsLayer
{
    partial class AddSecurityToModelForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.perc = new System.Windows.Forms.NumericUpDown();
            this.secID = new System.Windows.Forms.NumericUpDown();
            this.modID = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Security ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percentage";
            // 
            // perc
            // 
            this.perc.Location = new System.Drawing.Point(122, 97);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(120, 20);
            this.perc.TabIndex = 3;
            // 
            // secID
            // 
            this.secID.Location = new System.Drawing.Point(122, 61);
            this.secID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.secID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secID.Name = "secID";
            this.secID.Size = new System.Drawing.Size(120, 20);
            this.secID.TabIndex = 4;
            this.secID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // modID
            // 
            this.modID.Location = new System.Drawing.Point(122, 26);
            this.modID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.modID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modID.Name = "modID";
            this.modID.Size = new System.Drawing.Size(120, 20);
            this.modID.TabIndex = 5;
            this.modID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Security";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSecurityToModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modID);
            this.Controls.Add(this.secID);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSecurityToModelForm";
            this.Text = "New Model Security";
            ((System.ComponentModel.ISupportInitialize)(this.perc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown perc;
        private System.Windows.Forms.NumericUpDown secID;
        private System.Windows.Forms.NumericUpDown modID;
        private System.Windows.Forms.Button button1;
    }
}