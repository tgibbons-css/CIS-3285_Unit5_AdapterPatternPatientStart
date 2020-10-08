namespace AdapterPatternPatient
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbProcedure = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckCoverage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmtCovered = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(139, 86);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(121, 21);
            this.cbName.TabIndex = 0;
            // 
            // cbProcedure
            // 
            this.cbProcedure.FormattingEnabled = true;
            this.cbProcedure.Items.AddRange(new object[] {
            "Broken Arm",
            "Broken Wrist",
            "Broken Finger",
            "Broken Leg",
            "Broken Ankle",
            "Broken Toe"});
            this.cbProcedure.Location = new System.Drawing.Point(139, 143);
            this.cbProcedure.Name = "cbProcedure";
            this.cbProcedure.Size = new System.Drawing.Size(121, 21);
            this.cbProcedure.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Procedure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Charged";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(139, 204);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Patient Insurance Check";
            // 
            // btnCheckCoverage
            // 
            this.btnCheckCoverage.Location = new System.Drawing.Point(74, 252);
            this.btnCheckCoverage.Name = "btnCheckCoverage";
            this.btnCheckCoverage.Size = new System.Drawing.Size(121, 23);
            this.btnCheckCoverage.TabIndex = 7;
            this.btnCheckCoverage.Text = "Check Coverage";
            this.btnCheckCoverage.UseVisualStyleBackColor = true;
            this.btnCheckCoverage.Click += new System.EventHandler(this.btnCheckCoverage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount Covered";
            // 
            // txtAmtCovered
            // 
            this.txtAmtCovered.Location = new System.Drawing.Point(136, 296);
            this.txtAmtCovered.Name = "txtAmtCovered";
            this.txtAmtCovered.Size = new System.Drawing.Size(121, 20);
            this.txtAmtCovered.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.txtAmtCovered);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCheckCoverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProcedure);
            this.Controls.Add(this.cbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckCoverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmtCovered;
    }
}

