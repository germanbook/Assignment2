
namespace Assignment2
{
    partial class SaveData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveData));
            this.label1 = new System.Windows.Forms.Label();
            this.button1_Save = new System.Windows.Forms.Button();
            this.button2_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to save the data before exit !";
            // 
            // button1_Save
            // 
            this.button1_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1_Save.BackgroundImage")));
            this.button1_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1_Save.FlatAppearance.BorderSize = 0;
            this.button1_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_Save.Location = new System.Drawing.Point(86, 180);
            this.button1_Save.Name = "button1_Save";
            this.button1_Save.Size = new System.Drawing.Size(87, 23);
            this.button1_Save.TabIndex = 1;
            this.button1_Save.Text = "Save";
            this.button1_Save.UseVisualStyleBackColor = true;
            this.button1_Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_Save_MouseClick);
            this.button1_Save.MouseEnter += new System.EventHandler(this.button1_Save_MouseEnter);
            this.button1_Save.MouseLeave += new System.EventHandler(this.button1_Save_MouseLeave);
            // 
            // button2_Exit
            // 
            this.button2_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2_Exit.BackgroundImage")));
            this.button2_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2_Exit.FlatAppearance.BorderSize = 0;
            this.button2_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_Exit.Location = new System.Drawing.Point(289, 180);
            this.button2_Exit.Name = "button2_Exit";
            this.button2_Exit.Size = new System.Drawing.Size(87, 23);
            this.button2_Exit.TabIndex = 2;
            this.button2_Exit.Text = "Exit";
            this.button2_Exit.UseVisualStyleBackColor = true;
            this.button2_Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_Exit_MouseClick);
            this.button2_Exit.MouseEnter += new System.EventHandler(this.button2_Exit_MouseEnter);
            this.button2_Exit.MouseLeave += new System.EventHandler(this.button2_Exit_MouseLeave);
            // 
            // SaveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 254);
            this.Controls.Add(this.button2_Exit);
            this.Controls.Add(this.button1_Save);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SaveData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Save";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_Save;
        private System.Windows.Forms.Button button2_Exit;
    }
}