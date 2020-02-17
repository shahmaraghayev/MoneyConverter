namespace ValyutaConveter
{
    partial class Form1
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
            this.OK = new System.Windows.Forms.Button();
            this.ckbDollar = new System.Windows.Forms.CheckBox();
            this.ckbManat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCəm = new System.Windows.Forms.Label();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(197, 37);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ckbDollar
            // 
            this.ckbDollar.AutoSize = true;
            this.ckbDollar.Location = new System.Drawing.Point(12, 37);
            this.ckbDollar.Name = "ckbDollar";
            this.ckbDollar.Size = new System.Drawing.Size(53, 17);
            this.ckbDollar.TabIndex = 1;
            this.ckbDollar.Text = "Dollar";
            this.ckbDollar.UseVisualStyleBackColor = true;
            // 
            // ckbManat
            // 
            this.ckbManat.AutoSize = true;
            this.ckbManat.Location = new System.Drawing.Point(114, 37);
            this.ckbManat.Name = "ckbManat";
            this.ckbManat.Size = new System.Drawing.Size(56, 17);
            this.ckbManat.TabIndex = 2;
            this.ckbManat.Text = "Manat";
            this.ckbManat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Daxil et ";
            // 
            // lblCəm
            // 
            this.lblCəm.AutoSize = true;
            this.lblCəm.Location = new System.Drawing.Point(122, 85);
            this.lblCəm.Name = "lblCəm";
            this.lblCəm.Size = new System.Drawing.Size(28, 13);
            this.lblCəm.TabIndex = 4;
            this.lblCəm.Text = "Cəm";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(23, 100);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(69, 20);
            this.txtInsert.TabIndex = 5;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(125, 100);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(69, 20);
            this.txtResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.lblCəm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbManat);
            this.Controls.Add(this.ckbDollar);
            this.Controls.Add(this.OK);
            this.Name = "Form1";
            this.Text = "                         ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.CheckBox ckbDollar;
        private System.Windows.Forms.CheckBox ckbManat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCəm;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.TextBox txtResult;
    }
}

