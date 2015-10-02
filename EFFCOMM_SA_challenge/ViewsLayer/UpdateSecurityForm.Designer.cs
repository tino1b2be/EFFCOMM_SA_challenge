namespace EFFCOMM_SA_challenge.ViewsLayer
{
    partial class UpdateSecurityForm
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
            this.price = new System.Windows.Forms.NumericUpDown();
            this.id2 = new System.Windows.Forms.NumericUpDown();
            this.addSec = new System.Windows.Forms.Button();
            this.name2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modelName = new System.Windows.Forms.Label();
            this.modelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id2)).BeginInit();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(227, 98);
            this.price.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 22;
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(227, 26);
            this.id2.Maximum = new decimal(new int[] {
            10011,
            0,
            0,
            0});
            this.id2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(100, 20);
            this.id2.TabIndex = 21;
            this.id2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addSec
            // 
            this.addSec.Location = new System.Drawing.Point(141, 143);
            this.addSec.Name = "addSec";
            this.addSec.Size = new System.Drawing.Size(75, 23);
            this.addSec.TabIndex = 20;
            this.addSec.Text = "Add Security";
            this.addSec.UseVisualStyleBackColor = true;
            this.addSec.Click += new System.EventHandler(this.addSec_Click);
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(227, 61);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(100, 20);
            this.name2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Price";
            // 
            // modelName
            // 
            this.modelName.AutoSize = true;
            this.modelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelName.Location = new System.Drawing.Point(35, 61);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(132, 17);
            this.modelName.TabIndex = 17;
            this.modelName.Text = "Name of Security";
            // 
            // modelID
            // 
            this.modelID.AutoSize = true;
            this.modelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelID.Location = new System.Drawing.Point(35, 26);
            this.modelID.Name = "modelID";
            this.modelID.Size = new System.Drawing.Size(87, 17);
            this.modelID.TabIndex = 16;
            this.modelID.Text = "Security ID";
            // 
            // UpdateSecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 192);
            this.Controls.Add(this.price);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.addSec);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modelName);
            this.Controls.Add(this.modelID);
            this.Name = "UpdateSecurityForm";
            this.Text = "UpdateSecurityForm";
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.NumericUpDown id2;
        private System.Windows.Forms.Button addSec;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modelName;
        private System.Windows.Forms.Label modelID;
    }
}