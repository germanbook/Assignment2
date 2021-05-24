
namespace Assignment2
{
    partial class Hospital
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hospital));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4_UpdatePatient = new System.Windows.Forms.Button();
            this.button5_DischargedPatient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(322, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Long Term Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(322, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Day Patient";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(322, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "New Patient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_UpdatePatient
            // 
            this.button4_UpdatePatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4_UpdatePatient.BackgroundImage")));
            this.button4_UpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4_UpdatePatient.FlatAppearance.BorderSize = 0;
            this.button4_UpdatePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_UpdatePatient.Location = new System.Drawing.Point(322, 213);
            this.button4_UpdatePatient.Name = "button4_UpdatePatient";
            this.button4_UpdatePatient.Size = new System.Drawing.Size(116, 23);
            this.button4_UpdatePatient.TabIndex = 4;
            this.button4_UpdatePatient.Text = "Update Patient";
            this.button4_UpdatePatient.UseVisualStyleBackColor = true;
            this.button4_UpdatePatient.Click += new System.EventHandler(this.button4_UpdatePatient_Click);
            // 
            // button5_DischargedPatient
            // 
            this.button5_DischargedPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5_DischargedPatient.BackgroundImage")));
            this.button5_DischargedPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5_DischargedPatient.FlatAppearance.BorderSize = 0;
            this.button5_DischargedPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5_DischargedPatient.Location = new System.Drawing.Point(322, 270);
            this.button5_DischargedPatient.Name = "button5_DischargedPatient";
            this.button5_DischargedPatient.Size = new System.Drawing.Size(116, 23);
            this.button5_DischargedPatient.TabIndex = 5;
            this.button5_DischargedPatient.Text = "Discharged Patient";
            this.button5_DischargedPatient.UseVisualStyleBackColor = true;
            this.button5_DischargedPatient.Click += new System.EventHandler(this.button5_DischargedPatient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Location = new System.Drawing.Point(12, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5_DischargedPatient);
            this.Controls.Add(this.button4_UpdatePatient);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4_UpdatePatient;
        private System.Windows.Forms.Button button5_DischargedPatient;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

