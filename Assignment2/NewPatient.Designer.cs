
namespace Assignment2
{
    partial class NewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatient));
            this.name = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.TextBox();
            this.rfv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_newPatient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_doctor = new System.Windows.Forms.TextBox();
            this.newPatient_back = new System.Windows.Forms.Button();
            this.radioButton1_dayPatient = new System.Windows.Forms.RadioButton();
            this.radioButton2_longTermPatient = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(337, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(337, 83);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(187, 73);
            this.details.TabIndex = 1;
            // 
            // rfv
            // 
            this.rfv.Location = new System.Drawing.Point(337, 185);
            this.rfv.Multiline = true;
            this.rfv.Name = "rfv";
            this.rfv.Size = new System.Drawing.Size(187, 77);
            this.rfv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(239, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(239, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(239, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resan for visit*";
            // 
            // button1_newPatient
            // 
            this.button1_newPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1_newPatient.BackgroundImage")));
            this.button1_newPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1_newPatient.FlatAppearance.BorderSize = 0;
            this.button1_newPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_newPatient.Location = new System.Drawing.Point(374, 394);
            this.button1_newPatient.Name = "button1_newPatient";
            this.button1_newPatient.Size = new System.Drawing.Size(75, 23);
            this.button1_newPatient.TabIndex = 8;
            this.button1_newPatient.Text = "OK";
            this.button1_newPatient.UseVisualStyleBackColor = true;
            this.button1_newPatient.Click += new System.EventHandler(this.button1_Click);
            this.button1_newPatient.MouseEnter += new System.EventHandler(this.button1_newPatient_MouseEnter);
            this.button1_newPatient.MouseLeave += new System.EventHandler(this.button1_newPatient_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(243, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Doctor";
            // 
            // textBox1_doctor
            // 
            this.textBox1_doctor.Location = new System.Drawing.Point(337, 280);
            this.textBox1_doctor.Name = "textBox1_doctor";
            this.textBox1_doctor.Size = new System.Drawing.Size(100, 20);
            this.textBox1_doctor.TabIndex = 10;
            // 
            // newPatient_back
            // 
            this.newPatient_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newPatient_back.BackgroundImage")));
            this.newPatient_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newPatient_back.FlatAppearance.BorderSize = 0;
            this.newPatient_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPatient_back.Location = new System.Drawing.Point(563, 394);
            this.newPatient_back.Name = "newPatient_back";
            this.newPatient_back.Size = new System.Drawing.Size(75, 23);
            this.newPatient_back.TabIndex = 11;
            this.newPatient_back.Text = "Back";
            this.newPatient_back.UseVisualStyleBackColor = true;
            this.newPatient_back.Click += new System.EventHandler(this.newPatient_back_Click);
            this.newPatient_back.MouseEnter += new System.EventHandler(this.newPatient_back_MouseEnter);
            this.newPatient_back.MouseLeave += new System.EventHandler(this.newPatient_back_MouseLeave);
            // 
            // radioButton1_dayPatient
            // 
            this.radioButton1_dayPatient.AutoSize = true;
            this.radioButton1_dayPatient.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1_dayPatient.Location = new System.Drawing.Point(337, 318);
            this.radioButton1_dayPatient.Name = "radioButton1_dayPatient";
            this.radioButton1_dayPatient.Size = new System.Drawing.Size(80, 17);
            this.radioButton1_dayPatient.TabIndex = 12;
            this.radioButton1_dayPatient.TabStop = true;
            this.radioButton1_dayPatient.Text = "Day Patient";
            this.radioButton1_dayPatient.UseVisualStyleBackColor = false;
            // 
            // radioButton2_longTermPatient
            // 
            this.radioButton2_longTermPatient.AutoSize = true;
            this.radioButton2_longTermPatient.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2_longTermPatient.Checked = true;
            this.radioButton2_longTermPatient.Location = new System.Drawing.Point(337, 350);
            this.radioButton2_longTermPatient.Name = "radioButton2_longTermPatient";
            this.radioButton2_longTermPatient.Size = new System.Drawing.Size(112, 17);
            this.radioButton2_longTermPatient.TabIndex = 13;
            this.radioButton2_longTermPatient.TabStop = true;
            this.radioButton2_longTermPatient.Text = "Long Term Patient";
            this.radioButton2_longTermPatient.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(622, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "* = Required fields";
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2_longTermPatient);
            this.Controls.Add(this.radioButton1_dayPatient);
            this.Controls.Add(this.newPatient_back);
            this.Controls.Add(this.textBox1_doctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1_newPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rfv);
            this.Controls.Add(this.details);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPatient";
            this.Text = "NewPatient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.TextBox rfv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_newPatient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_doctor;
        private System.Windows.Forms.Button newPatient_back;
        private System.Windows.Forms.RadioButton radioButton1_dayPatient;
        private System.Windows.Forms.RadioButton radioButton2_longTermPatient;
        private System.Windows.Forms.Label label5;
    }
}