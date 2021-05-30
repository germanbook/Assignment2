
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePatient));
            this.listView1_UpdatePatient = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_searchByNameOrID = new System.Windows.Forms.TextBox();
            this.label2_NoResultFound = new System.Windows.Forms.Label();
            this.label2_Match = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1_UpdatePatient
            // 
            this.listView1_UpdatePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1_UpdatePatient.BackColor = System.Drawing.Color.White;
            this.listView1_UpdatePatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader1});
            this.listView1_UpdatePatient.FullRowSelect = true;
            this.listView1_UpdatePatient.GridLines = true;
            this.listView1_UpdatePatient.HideSelection = false;
            this.listView1_UpdatePatient.Location = new System.Drawing.Point(12, 62);
            this.listView1_UpdatePatient.MultiSelect = false;
            this.listView1_UpdatePatient.Name = "listView1_UpdatePatient";
            this.listView1_UpdatePatient.Size = new System.Drawing.Size(830, 458);
            this.listView1_UpdatePatient.TabIndex = 0;
            this.listView1_UpdatePatient.UseCompatibleStateImageBehavior = false;
            this.listView1_UpdatePatient.View = System.Windows.Forms.View.Details;
            this.listView1_UpdatePatient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_UpdatePatient_MouseDoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Patient ID";
            this.columnHeader8.Width = 96;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Name";
            this.columnHeader9.Width = 96;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Details";
            this.columnHeader10.Width = 98;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Reason for Visit";
            this.columnHeader11.Width = 122;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Long Term/Day Patient";
            this.columnHeader12.Width = 145;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Doctor";
            this.columnHeader13.Width = 79;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            this.columnHeader1.Width = 86;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(383, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Name or ID";
            // 
            // textBox1_searchByNameOrID
            // 
            this.textBox1_searchByNameOrID.Location = new System.Drawing.Point(126, 23);
            this.textBox1_searchByNameOrID.Name = "textBox1_searchByNameOrID";
            this.textBox1_searchByNameOrID.Size = new System.Drawing.Size(118, 20);
            this.textBox1_searchByNameOrID.TabIndex = 3;
            this.textBox1_searchByNameOrID.TextChanged += new System.EventHandler(this.listView1_UpdatePatient_SelectedIndexChanged);
            // 
            // label2_NoResultFound
            // 
            this.label2_NoResultFound.AutoSize = true;
            this.label2_NoResultFound.BackColor = System.Drawing.Color.Transparent;
            this.label2_NoResultFound.Location = new System.Drawing.Point(271, 26);
            this.label2_NoResultFound.Name = "label2_NoResultFound";
            this.label2_NoResultFound.Size = new System.Drawing.Size(87, 13);
            this.label2_NoResultFound.TabIndex = 4;
            this.label2_NoResultFound.Text = "No Result Found";
            this.label2_NoResultFound.Visible = false;
            // 
            // label2_Match
            // 
            this.label2_Match.AutoSize = true;
            this.label2_Match.BackColor = System.Drawing.Color.Transparent;
            this.label2_Match.Location = new System.Drawing.Point(283, 26);
            this.label2_Match.Name = "label2_Match";
            this.label2_Match.Size = new System.Drawing.Size(37, 13);
            this.label2_Match.TabIndex = 5;
            this.label2_Match.Text = "Match";
            this.label2_Match.Visible = false;
            // 
            // UpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 574);
            this.Controls.Add(this.label2_Match);
            this.Controls.Add(this.label2_NoResultFound);
            this.Controls.Add(this.textBox1_searchByNameOrID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1_UpdatePatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdatePatient";
            this.Text = "Update Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1_UpdatePatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_searchByNameOrID;
        private System.Windows.Forms.Label label2_NoResultFound;
        private System.Windows.Forms.Label label2_Match;
    }
}