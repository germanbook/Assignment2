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
    * Long-term patient or day patient
    * Display either long-term patient or day patient
    * 
    */
    public partial class LongTerm_Day_Patient : Form
    {
        Hospital _hospital;
        string tempButton;
        public LongTerm_Day_Patient(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;
            StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        // Display long-term patient or day patient
        // according to which button clicked
        public void ShowLongTermDayPatients(string _button)
        {
            tempButton = _button;
            List<Patient> p = new List<Patient>();
            listView1_Patients.Items.Clear();
            if (tempButton == "button1")
            {
                p = Functions.ShowLongTermPatients();
            } 
            else if (tempButton == "button2")
            {
                p = Functions.ShowDayPatients();
            }
            for (int i = 0; i < p.Count; i++)
            {
                listView1_Patients.Items.Add(p[i].ID);
                listView1_Patients.Items[i].SubItems.Add(p[i].Name);
                listView1_Patients.Items[i].SubItems.Add(p[i].Details);
                listView1_Patients.Items[i].SubItems.Add(p[i].Rfv);
                if (p[i].LongTerm == true)
                {
                    listView1_Patients.Items[i].SubItems.Add("Long Term");
                }
                else
                {
                    listView1_Patients.Items[i].SubItems.Add("Day Patient");
                }
                
                listView1_Patients.Items[i].SubItems.Add(p[i].Doctor);
            }
            if (listView1_Patients.Items.Count == 0)
                listView1_Patients.Items.Add("No Data!");
        }

        // Back to main menu
        private void button1_Click(object sender, EventArgs e)
        {
            _hospital.Show();
            this.Hide();
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

        // Search patient by ID or name
        private void textBox1_searchByNameOrID_TextChanged(object sender, EventArgs e)
        {
            List<Patient> p = Hospital.patients.Where(patient => patient.Name.Contains(textBox1_searchByNameOrID.Text) ||
                                            patient.ID.Contains(textBox1_searchByNameOrID.Text)).ToList();

            if (tempButton == "button1")
            { 
                var patients =
                from patient in p
                where patient.LongTerm == true
                select patient;

                p = patients.ToList();

            }
            else if (tempButton == "button2")
            {
                var patients =
                from patient in p
                where patient.LongTerm == false
                select patient;

                p = patients.ToList();
            }

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
                this.ShowLongTermDayPatients(tempButton);
                label2_NoResultFound.Visible = label2_Match.Visible = false;
            }

        }
        
        // Display matched patient by search
        public void ShowPatientsListview(List<Patient> p)
        {
            listView1_Patients.Items.Clear();
            for (int i = 0; i < p.Count; i++)
            {
                listView1_Patients.Items.Add(p[i].ID);
                listView1_Patients.Items[i].SubItems.Add(p[i].Name);
                listView1_Patients.Items[i].SubItems.Add(p[i].Details);
                listView1_Patients.Items[i].SubItems.Add(p[i].Rfv);
                if (p[i].LongTerm == true)
                {
                    listView1_Patients.Items[i].SubItems.Add("Long Term");
                }
                else
                {
                    listView1_Patients.Items[i].SubItems.Add("Day Patient");
                }
                listView1_Patients.Items[i].SubItems.Add(p[i].Doctor);
                if (p[i].Discharged == true)
                {
                    listView1_Patients.Items[i].SubItems.Add("Discharged");
                }
                else
                {
                    listView1_Patients.Items[i].SubItems.Add("Active");
                }

            }
            if (listView1_Patients.Items.Count == 0)
                listView1_Patients.Items.Add("No Data!");
        }
    }
}
