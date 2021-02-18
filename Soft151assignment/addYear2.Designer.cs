namespace Soft151assignment
{
    partial class addYear2
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtHoursOfSun = new System.Windows.Forms.TextBox();
            this.txtMilsOfRain = new System.Windows.Forms.TextBox();
            this.txtNumOfFrostDays = new System.Windows.Forms.TextBox();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(11, 17);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(0, 13);
            this.lblMonth.TabIndex = 24;
            // 
            // txtHoursOfSun
            // 
            this.txtHoursOfSun.Location = new System.Drawing.Point(173, 161);
            this.txtHoursOfSun.Name = "txtHoursOfSun";
            this.txtHoursOfSun.Size = new System.Drawing.Size(100, 20);
            this.txtHoursOfSun.TabIndex = 23;
            // 
            // txtMilsOfRain
            // 
            this.txtMilsOfRain.Location = new System.Drawing.Point(173, 135);
            this.txtMilsOfRain.Name = "txtMilsOfRain";
            this.txtMilsOfRain.Size = new System.Drawing.Size(100, 20);
            this.txtMilsOfRain.TabIndex = 22;
            // 
            // txtNumOfFrostDays
            // 
            this.txtNumOfFrostDays.Location = new System.Drawing.Point(173, 109);
            this.txtNumOfFrostDays.Name = "txtNumOfFrostDays";
            this.txtNumOfFrostDays.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfFrostDays.TabIndex = 21;
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(173, 82);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMinTemp.TabIndex = 20;
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(173, 55);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMaxTemp.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hours of sun shine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mils of rainfall";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Number of Frost days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Minimum Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Maximum Temp";
            // 
            // btnSaveMonth
            // 
            this.btnSaveMonth.Location = new System.Drawing.Point(18, 211);
            this.btnSaveMonth.Name = "btnSaveMonth";
            this.btnSaveMonth.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMonth.TabIndex = 25;
            this.btnSaveMonth.Text = "Save month";
            this.btnSaveMonth.UseVisualStyleBackColor = true;
            this.btnSaveMonth.Click += new System.EventHandler(this.btnSaveMonth_Click);
            // 
            // addYear2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 252);
            this.Controls.Add(this.btnSaveMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.txtHoursOfSun);
            this.Controls.Add(this.txtMilsOfRain);
            this.Controls.Add(this.txtNumOfFrostDays);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "addYear2";
            this.Text = "addYear2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtHoursOfSun;
        private System.Windows.Forms.TextBox txtMilsOfRain;
        private System.Windows.Forms.TextBox txtNumOfFrostDays;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveMonth;
    }
}