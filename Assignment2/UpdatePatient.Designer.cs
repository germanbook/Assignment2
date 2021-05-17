
namespace Assignment2
{
    partial class UpdatePatient
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
            this.listView1_UpdatePatient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1_UpdatePatient
            // 
            this.listView1_UpdatePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1_UpdatePatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1_UpdatePatient.FullRowSelect = true;
            this.listView1_UpdatePatient.GridLines = true;
            this.listView1_UpdatePatient.HideSelection = false;
            this.listView1_UpdatePatient.Location = new System.Drawing.Point(12, 12);
            this.listView1_UpdatePatient.MultiSelect = false;
            this.listView1_UpdatePatient.Name = "listView1_UpdatePatient";
            this.listView1_UpdatePatient.Size = new System.Drawing.Size(776, 384);
            this.listView1_UpdatePatient.TabIndex = 0;
            this.listView1_UpdatePatient.UseCompatibleStateImageBehavior = false;
            this.listView1_UpdatePatient.View = System.Windows.Forms.View.Details;
            this.listView1_UpdatePatient.SelectedIndexChanged += new System.EventHandler(this.listView1_UpdatePatient_SelectedIndexChanged);
            this.listView1_UpdatePatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_UpdatePatient_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Details";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reason for Visit";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Long Term/Day Patient";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Doctor";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 90;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1_UpdatePatient);
            this.Name = "UpdatePatient";
            this.Text = "Update Patient";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1_UpdatePatient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
    }
}