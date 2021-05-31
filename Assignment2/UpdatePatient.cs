using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    /**
    * Update patient
    * Show patient list by doubleclick one of them gose
    * to edit form
    * Search patient by ID or name
    */
    public partial class UpdatePatient : Form
    {
        Hospital _hospital;
        public UpdatePatient(Hospital hospital)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _hospital = hospital;
            this.ControlBox = false;
        }

        public UpdatePatient(){}

        // Search patient by ID or name
        private void listView1_UpdatePatient_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Patient> p = Hospital.patients.Where( patient => patient.Name.Contains(textBox1_searchByNameOrID.Text) | 
                                             patient.ID.Contains(textBox1_searchByNameOrID.Text)).ToList();
            if (textBox1_searchByNameOrID.Text != "")
            {
                if (p.Count != 0)
                {
                    label2_NoResultFound.Visible = false;
                    label2_Match.Visible = true;
                    this.ShowPatientsListview(p);
                    if (p.Count == 1)
                    {
                        label2_Match.Text = p.Count + " match";
                    }
                    else
                    {
                        label2_Match.Text = p.Count + " matches";
                    }

                }
                else
                {
                    label2_NoResultFound.Visible = true;
                    label2_Match.Visible = false;
                }
            }
            else
            {
                this.ShowAllPatients();
                label2_NoResultFound.Visible = label2_Match.Visible = false;
            }
                
        }

        // Back to main menu
        private void button1_Click(object sender, EventArgs e)
        {
            _hospital.Show();
            this.Hide();
        }

        // Display all patient
        public void ShowAllPatients()
        {
            List<Patient> p = Functions.ShowAllPatients();
            this.ShowPatientsListview(p);
            
        }

        // Display matched patient by search
        public void ShowPatientsListview(List<Patient> p)
        {
            listView1_UpdatePatient.Items.Clear();
            for (int i = 0; i < p.Count; i++)
            {
                listView1_UpdatePatient.Items.Add(p[i].ID);
                listView1_UpdatePatient.Items[i].SubItems.Add(p[i].Name);
                listView1_UpdatePatient.Items[i].SubItems.Add(p[i].Details);
                listView1_UpdatePatient.Items[i].SubItems.Add(p[i].Rfv);
                if (p[i].LongTerm == true)
                {
                    listView1_UpdatePatient.Items[i].SubItems.Add("Long Term");
                }
                else
                {
                    listView1_UpdatePatient.Items[i].SubItems.Add("Day Patient");
                }
                listView1_UpdatePatient.Items[i].SubItems.Add(p[i].Doctor);
                if (p[i].Discharged == true)
                {
                    listView1_UpdatePatient.Items[i].SubItems.Add("Discharged");
                }
                else
                {
                    listView1_UpdatePatient.Items[i].SubItems.Add("Active");
                }

            }
            if (listView1_UpdatePatient.Items.Count == 0)
                listView1_UpdatePatient.Items.Add("No Data!");
        }

        // Mouse double click item to goes to edit form
        private void listView1_UpdatePatient_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (this.listView1_UpdatePatient.FocusedItem != null)
            {
                if (listView1_UpdatePatient.SelectedItems != null)
                {

                    UpdatePatient2 patient = new UpdatePatient2(this);
                    patient.Show();
                    patient.ShowSelectedPatient(listView1_UpdatePatient.FocusedItem.Text);
                    this.Hide();
                }
            }
        }

        // Mouse hover effects on button
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
