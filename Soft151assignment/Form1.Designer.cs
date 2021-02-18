namespace Soft151assignment
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
            this.components = new System.ComponentModel.Container();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btnDisplayYear = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisplayMonth = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cbSelectLocation = new System.Windows.Forms.ComboBox();
            this.cbSelectYear = new System.Windows.Forms.ComboBox();
            this.cbSelectMonth = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnDisplayLocation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAnalysisYear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 194);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(780, 199);
            this.lstOutput.TabIndex = 1;
            // 
            // btnDisplayYear
            // 
            this.btnDisplayYear.Location = new System.Drawing.Point(9, 67);
            this.btnDisplayYear.Name = "btnDisplayYear";
            this.btnDisplayYear.Size = new System.Drawing.Size(118, 38);
            this.btnDisplayYear.TabIndex = 2;
            this.btnDisplayYear.Text = "Display Year";
            this.btnDisplayYear.UseVisualStyleBackColor = true;
            this.btnDisplayYear.Click += new System.EventHandler(this.btnDisplayYear_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Enabled = false;
            this.btnEditYear.Location = new System.Drawing.Point(9, 18);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(118, 38);
            this.btnEditYear.TabIndex = 3;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Enabled = false;
            this.btnAddYear.Location = new System.Drawing.Point(9, 62);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(118, 38);
            this.btnAddYear.TabIndex = 4;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter year :";
            // 
            // btnDisplayMonth
            // 
            this.btnDisplayMonth.Location = new System.Drawing.Point(9, 111);
            this.btnDisplayMonth.Name = "btnDisplayMonth";
            this.btnDisplayMonth.Size = new System.Drawing.Size(118, 38);
            this.btnDisplayMonth.TabIndex = 7;
            this.btnDisplayMonth.Text = "Display Month";
            this.btnDisplayMonth.UseVisualStyleBackColor = true;
            this.btnDisplayMonth.Click += new System.EventHandler(this.btnDisplayMonth_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter Month :";
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Enabled = false;
            this.btnEditMonth.Location = new System.Drawing.Point(8, 19);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(118, 38);
            this.btnEditMonth.TabIndex = 12;
            this.btnEditMonth.Text = "Edit Month";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // cbSelectLocation
            // 
            this.cbSelectLocation.FormattingEnabled = true;
            this.cbSelectLocation.Location = new System.Drawing.Point(234, 41);
            this.cbSelectLocation.Name = "cbSelectLocation";
            this.cbSelectLocation.Size = new System.Drawing.Size(121, 21);
            this.cbSelectLocation.TabIndex = 14;
            this.cbSelectLocation.SelectedIndexChanged += new System.EventHandler(this.cbSelectLocation_SelectedIndexChanged);
            // 
            // cbSelectYear
            // 
            this.cbSelectYear.FormattingEnabled = true;
            this.cbSelectYear.Location = new System.Drawing.Point(234, 68);
            this.cbSelectYear.Name = "cbSelectYear";
            this.cbSelectYear.Size = new System.Drawing.Size(121, 21);
            this.cbSelectYear.TabIndex = 15;
            this.cbSelectYear.SelectedIndexChanged += new System.EventHandler(this.cbSelectYear_SelectedIndexChanged);
            // 
            // cbSelectMonth
            // 
            this.cbSelectMonth.FormattingEnabled = true;
            this.cbSelectMonth.Location = new System.Drawing.Point(234, 99);
            this.cbSelectMonth.Name = "cbSelectMonth";
            this.cbSelectMonth.Size = new System.Drawing.Size(121, 21);
            this.cbSelectMonth.TabIndex = 16;
            this.cbSelectMonth.SelectedIndexChanged += new System.EventHandler(this.cbSelectMonth_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter Location :";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(8, 62);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(118, 38);
            this.btnAddLocation.TabIndex = 19;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Enabled = false;
            this.btnEditLocation.Location = new System.Drawing.Point(8, 18);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(118, 38);
            this.btnEditLocation.TabIndex = 18;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnDisplayLocation
            // 
            this.btnDisplayLocation.Location = new System.Drawing.Point(9, 23);
            this.btnDisplayLocation.Name = "btnDisplayLocation";
            this.btnDisplayLocation.Size = new System.Drawing.Size(118, 38);
            this.btnDisplayLocation.TabIndex = 20;
            this.btnDisplayLocation.Text = "Display Location";
            this.btnDisplayLocation.UseVisualStyleBackColor = true;
            this.btnDisplayLocation.Click += new System.EventHandler(this.btnDisplayLocation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDisplayLocation);
            this.groupBox1.Controls.Add(this.btnDisplayMonth);
            this.groupBox1.Controls.Add(this.btnDisplayYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 162);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddLocation);
            this.groupBox2.Controls.Add(this.btnEditLocation);
            this.groupBox2.Location = new System.Drawing.Point(372, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 117);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAnalysisYear);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnAddYear);
            this.groupBox3.Controls.Add(this.btnEditYear);
            this.groupBox3.Location = new System.Drawing.Point(518, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 160);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Year";
            // 
            // btnAnalysisYear
            // 
            this.btnAnalysisYear.Enabled = false;
            this.btnAnalysisYear.Location = new System.Drawing.Point(9, 106);
            this.btnAnalysisYear.Name = "btnAnalysisYear";
            this.btnAnalysisYear.Size = new System.Drawing.Size(118, 38);
            this.btnAnalysisYear.TabIndex = 25;
            this.btnAnalysisYear.Text = "Analysis Year";
            this.btnAnalysisYear.UseVisualStyleBackColor = true;
            this.btnAnalysisYear.Click += new System.EventHandler(this.btnAnalysisYear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(145, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(137, 117);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Year";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnEditMonth);
            this.groupBox5.Location = new System.Drawing.Point(666, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 117);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Month";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit Progam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSelectMonth);
            this.Controls.Add(this.cbSelectYear);
            this.Controls.Add(this.cbSelectLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btnDisplayYear;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisplayMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbSelectLocation;
        private System.Windows.Forms.ComboBox cbSelectYear;
        private System.Windows.Forms.ComboBox cbSelectMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnDisplayLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAnalysisYear;
        private System.Windows.Forms.Button button1;
    }
}

