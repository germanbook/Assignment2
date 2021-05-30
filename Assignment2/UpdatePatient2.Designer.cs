
namespace Assignment2
{
    partial class UpdatePatient2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePatient2));
            this.label1_name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2_details = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3_reason = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4_doctor = new System.Windows.Forms.Label();
            this.radioButton1_dayPatient = new System.Windows.Forms.RadioButton();
            this.radioButton2_longTermPatient = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2_back = new System.Windows.Forms.Button();
            this.textBox5_patientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.BackColor = System.Drawing.Color.Transparent;
            this.label1_name.Location = new System.Drawing.Point(210, 78);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(35, 13);
            this.label1_name.TabIndex = 0;
            this.label1_name.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(302, 119);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 88);
            this.textBox2.TabIndex = 3;
            // 
            // label2_details
            // 
            this.label2_details.AutoSize = true;
            this.label2_details.BackColor = System.Drawing.Color.Transparent;
            this.label2_details.Location = new System.Drawing.Point(210, 127);
            this.label2_details.Name = "label2_details";
            this.label2_details.Size = new System.Drawing.Size(39, 13);
            this.label2_details.TabIndex = 2;
            this.label2_details.Text = "Details";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(302, 237);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 91);
            this.textBox3.TabIndex = 5;
            // 
            // label3_reason
            // 
            this.label3_reason.AutoSize = true;
            this.label3_reason.BackColor = System.Drawing.Color.Transparent;
            this.label3_reason.Location = new System.Drawing.Point(210, 245);
            this.label3_reason.Name = "label3_reason";
            this.label3_reason.Size = new System.Drawing.Size(44, 13);
            this.label3_reason.TabIndex = 4;
            this.label3_reason.Text = "Reason";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(302, 351);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4_doctor
            // 
            this.label4_doctor.AutoSize = true;
            this.label4_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label4_doctor.Location = new System.Drawing.Point(210, 351);
            this.label4_doctor.Name = "label4_doctor";
            this.label4_doctor.Size = new System.Drawing.Size(39, 13);
            this.label4_doctor.TabIndex = 6;
            this.label4_doctor.Text = "Doctor";
            // 
            // radioButton1_dayPatient
            // 
            this.radioButton1_dayPatient.AutoSize = true;
            this.radioButton1_dayPatient.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1_dayPatient.Location = new System.Drawing.Point(302, 393);
            this.radioButton1_dayPatient.Name = "radioButton1_dayPatient";
            this.radioButton1_dayPatient.Size = new System.Drawing.Size(80, 17);
            this.radioButton1_dayPatient.TabIndex = 8;
            this.radioButton1_dayPatient.TabStop = true;
            this.radioButton1_dayPatient.Text = "Day Patient";
            this.radioButton1_dayPatient.UseVisualStyleBackColor = false;
            // 
            // radioButton2_longTermPatient
            // 
            this.radioButton2_longTermPatient.AutoSize = true;
            this.radioButton2_longTermPatient.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2_longTermPatient.Location = new System.Drawing.Point(302, 425);
            this.radioButton2_longTermPatient.Name = "radioButton2_longTermPatient";
            this.radioButton2_longTermPatient.Size = new System.Drawing.Size(112, 17);
            this.radioButton2_longTermPatient.TabIndex = 9;
            this.radioButton2_longTermPatient.TabStop = true;
            this.radioButton2_longTermPatient.Text = "Long Term Patient";
            this.radioButton2_longTermPatient.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active Patient",
            "Discharged Patient"});
            this.comboBox1.Location = new System.Drawing.Point(302, 479);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(302, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2_back
            // 
            this.button2_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2_back.BackgroundImage")));
            this.button2_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2_back.FlatAppearance.BorderSize = 0;
            this.button2_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_back.Location = new System.Drawing.Point(500, 554);
            this.button2_back.Name = "button2_back";
            this.button2_back.Size = new System.Drawing.Size(75, 23);
            this.button2_back.TabIndex = 14;
            this.button2_back.Text = "Back";
            this.button2_back.UseVisualStyleBackColor = true;
            this.button2_back.Click += new System.EventHandler(this.button2_back_Click);
            // 
            // textBox5_patientID
            // 
            this.textBox5_patientID.Location = new System.Drawing.Point(302, 28);
            this.textBox5_patientID.Name = "textBox5_patientID";
            this.textBox5_patientID.ReadOnly = true;
            this.textBox5_patientID.Size = new System.Drawing.Size(100, 20);
            this.textBox5_patientID.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(200, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Patient ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // UpdatePatient2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 616);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5_patientID);
            this.Controls.Add(this.button2_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2_longTermPatient);
            this.Controls.Add(this.radioButton1_dayPatient);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4_doctor);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3_reason);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2_details);
            this.Controls.Add(this.label1_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePatient2";
            this.Text = "Update Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2_details;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3_reason;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4_doctor;
        private System.Windows.Forms.RadioButton radioButton1_dayPatient;
        private System.Windows.Forms.RadioButton radioButton2_longTermPatient;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2_back;
        private System.Windows.Forms.TextBox textBox5_patientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}