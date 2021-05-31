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
    * Patient edit form
    * Edit selected patient in this form
    */
    public partial class UpdatePatient2 : Form
    {
        UpdatePatient _updatePatient;
        public UpdatePatient2(UpdatePatient patient)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _updatePatient = patient;
        }

        // Display selected patient details
        public void ShowSelectedPatient(string id )
        {
            List<Patient> p = new List<Patient>();
            p = Functions.ShowPatientsByID(id);
            textBox5_patientID.Text = p[0].ID;
            textBox1.Text = p[0].Name;
            textBox2.Text = p[0].Details;
            textBox3.Text = p[0].Rfv;
            textBox4.Text = p[0].Doctor;
            if (p[0].LongTerm == true)
            {
                radioButton2_longTermPatient.Checked = true;
            }
            else
            {
                radioButton1_dayPatient.Checked = true;
            }
            if (p[0].Discharged == true)
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
            
        }

        // Back to preview menu
        private void button2_back_Click(object sender, EventArgs e)
        {
            _updatePatient.Show();
            _updatePatient.ShowAllPatients();
            this.Hide();
        }

        // Update patient details from user input
        private void button1_Click(object sender, EventArgs e)
        {
            var updatePatient = new Task(() =>
            {
                List<Patient> p = new List<Patient>();
                p = Functions.ShowPatientsByID(textBox5_patientID.Text);

                p[0].Name = textBox1.Text;
                p[0].Details = textBox2.Text;
                p[0].Rfv = textBox3.Text;
                p[0].Doctor = textBox4.Text;

                if (radioButton2_longTermPatient.Checked == true)
                {
                    p[0].LongTerm = true;
                }
                else
                {
                    p[0].LongTerm = false;
                }

                if (comboBox1.SelectedIndex == 1)
                {
                    p[0].Discharged = true;
                }
                else
                {
                    p[0].Discharged = false;
                }

                MessageBox.Show("Patient has been updated!");
            });            
            updatePatient.RunSynchronously();
            
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
