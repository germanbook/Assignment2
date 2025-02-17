﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2_Save = new System.Windows.Forms.PictureBox();
            this.pictureBox_MouseEnter = new System.Windows.Forms.PictureBox();
            this.pictureBox_MouseLeave = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MouseEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MouseLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(322, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Long Term Patient";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
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
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(322, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "New Patient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
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
            this.button4_UpdatePatient.Text = "Search and Update";
            this.button4_UpdatePatient.UseVisualStyleBackColor = true;
            this.button4_UpdatePatient.Click += new System.EventHandler(this.button4_UpdatePatient_Click);
            this.button4_UpdatePatient.MouseEnter += new System.EventHandler(this.button4_MouseEnter);
            this.button4_UpdatePatient.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
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
            this.button5_DischargedPatient.MouseEnter += new System.EventHandler(this.button5_DischargedPatient_Click_MouseEnter);
            this.button5_DischargedPatient.MouseLeave += new System.EventHandler(this.button5_DischargedPatient_Click_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 374);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 141);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2_Save
            // 
            this.pictureBox2_Save.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2_Save.BackgroundImage")));
            this.pictureBox2_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2_Save.Location = new System.Drawing.Point(48, 46);
            this.pictureBox2_Save.Name = "pictureBox2_Save";
            this.pictureBox2_Save.Size = new System.Drawing.Size(63, 60);
            this.pictureBox2_Save.TabIndex = 7;
            this.pictureBox2_Save.TabStop = false;
            this.pictureBox2_Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_Save_MouseClick);
            this.pictureBox2_Save.MouseEnter += new System.EventHandler(this.pictureBox2_Save_MouseEnter);
            this.pictureBox2_Save.MouseLeave += new System.EventHandler(this.pictureBox2_Save_MouseLeave);
            // 
            // pictureBox_MouseEnter
            // 
            this.pictureBox_MouseEnter.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_MouseEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_MouseEnter.BackgroundImage")));
            this.pictureBox_MouseEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_MouseEnter.Location = new System.Drawing.Point(117, 46);
            this.pictureBox_MouseEnter.Name = "pictureBox_MouseEnter";
            this.pictureBox_MouseEnter.Size = new System.Drawing.Size(58, 60);
            this.pictureBox_MouseEnter.TabIndex = 9;
            this.pictureBox_MouseEnter.TabStop = false;
            this.pictureBox_MouseEnter.Visible = false;
            // 
            // pictureBox_MouseLeave
            // 
            this.pictureBox_MouseLeave.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_MouseLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_MouseLeave.BackgroundImage")));
            this.pictureBox_MouseLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_MouseLeave.Location = new System.Drawing.Point(117, 46);
            this.pictureBox_MouseLeave.Name = "pictureBox_MouseLeave";
            this.pictureBox_MouseLeave.Size = new System.Drawing.Size(58, 60);
            this.pictureBox_MouseLeave.TabIndex = 10;
            this.pictureBox_MouseLeave.TabStop = false;
            this.pictureBox_MouseLeave.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Save";
            // 
            // button4_Exit
            // 
            this.button4_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4_Exit.BackgroundImage")));
            this.button4_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4_Exit.FlatAppearance.BorderSize = 0;
            this.button4_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_Exit.Location = new System.Drawing.Point(322, 415);
            this.button4_Exit.Name = "button4_Exit";
            this.button4_Exit.Size = new System.Drawing.Size(116, 23);
            this.button4_Exit.TabIndex = 12;
            this.button4_Exit.Text = "Exit";
            this.button4_Exit.UseVisualStyleBackColor = true;
            this.button4_Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button4_Exit_MouseClick);
            this.button4_Exit.MouseEnter += new System.EventHandler(this.button4_Exit_MouseEnter);
            this.button4_Exit.MouseLeave += new System.EventHandler(this.button4_Exit_MouseLeave);
            // 
            // Hospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 527);
            this.Controls.Add(this.button4_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_MouseLeave);
            this.Controls.Add(this.pictureBox_MouseEnter);
            this.Controls.Add(this.pictureBox2_Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5_DischargedPatient);
            this.Controls.Add(this.button4_UpdatePatient);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Hospital";
            this.Text = "Hospital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hospital_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MouseEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_MouseLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4_UpdatePatient;
        private System.Windows.Forms.Button button5_DischargedPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2_Save;
        private System.Windows.Forms.PictureBox pictureBox_MouseEnter;
        private System.Windows.Forms.PictureBox pictureBox_MouseLeave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4_Exit;
    }
}

