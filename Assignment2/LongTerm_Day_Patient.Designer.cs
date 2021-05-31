
namespace Assignment2
{
    partial class LongTerm_Day_Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LongTerm_Day_Patient));
            this.listView1_Patients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label2_Match = new System.Windows.Forms.Label();
            this.label2_NoResultFound = new System.Windows.Forms.Label();
            this.textBox1_searchByNameOrID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1_Patients
            // 
            this.listView1_Patients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1_Patients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1_Patients.FullRowSelect = true;
            this.listView1_Patients.GridLines = true;
            this.listView1_Patients.HideSelection = false;
            this.listView1_Patients.Location = new System.Drawing.Point(12, 42);
            this.listView1_Patients.Name = "listView1_Patients";
            this.listView1_Patients.Size = new System.Drawing.Size(776, 354);
            this.listView1_Patients.TabIndex = 0;
            this.listView1_Patients.UseCompatibleStateImageBehavior = false;
            this.listView1_Patients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Patient ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Details";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Reson for Visit";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Long Term/Day Patient";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Doctor";
            this.columnHeader6.Width = 98;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(360, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label2_Match
            // 
            this.label2_Match.AutoSize = true;
            this.label2_Match.BackColor = System.Drawing.Color.Transparent;
            this.label2_Match.Location = new System.Drawing.Point(283, 15);
            this.label2_Match.Name = "label2_Match";
            this.label2_Match.Size = new System.Drawing.Size(37, 13);
            this.label2_Match.TabIndex = 9;
            this.label2_Match.Text = "Match";
            this.label2_Match.Visible = false;
            // 
            // label2_NoResultFound
            // 
            this.label2_NoResultFound.AutoSize = true;
            this.label2_NoResultFound.BackColor = System.Drawing.Color.Transparent;
            this.label2_NoResultFound.Location = new System.Drawing.Point(271, 15);
            this.label2_NoResultFound.Name = "label2_NoResultFound";
            this.label2_NoResultFound.Size = new System.Drawing.Size(87, 13);
            this.label2_NoResultFound.TabIndex = 8;
            this.label2_NoResultFound.Text = "No Result Found";
            this.label2_NoResultFound.Visible = false;
            // 
            // textBox1_searchByNameOrID
            // 
            this.textBox1_searchByNameOrID.Location = new System.Drawing.Point(126, 12);
            this.textBox1_searchByNameOrID.Name = "textBox1_searchByNameOrID";
            this.textBox1_searchByNameOrID.Size = new System.Drawing.Size(118, 20);
            this.textBox1_searchByNameOrID.TabIndex = 7;
            this.textBox1_searchByNameOrID.TextChanged += new System.EventHandler(this.textBox1_searchByNameOrID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search by Name or ID";
            // 
            // LongTerm_Day_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2_Match);
            this.Controls.Add(this.label2_NoResultFound);
            this.Controls.Add(this.textBox1_searchByNameOrID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1_Patients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LongTerm_Day_Patient";
            this.Text = "Patients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1_Patients;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2_Match;
        private System.Windows.Forms.Label label2_NoResultFound;
        private System.Windows.Forms.TextBox textBox1_searchByNameOrID;
        private System.Windows.Forms.Label label1;
    }
}