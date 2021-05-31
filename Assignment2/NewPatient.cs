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
    * New patient
    * Add a patient
    */
    public partial class NewPatient : Form
    {
        Hospital _hospital;
        public NewPatient(Hospital hospital)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _hospital = hospital;
        }

        // New a patient
        private void button1_Click(object sender, EventArgs e)
        {
            // Checks if the required fields have been filled
            if (name.Text.Length > 0 & rfv.Text.Length > 0)
            {
                Patient newPatient = new Patient(name.Text, details.Text, rfv.Text, radioButton2_longTermPatient.Checked, false, textBox1_doctor.Text);
                Hospital.patients.Add(newPatient);

                MessageBox.Show("Patient has been added!");
            }
            // if required fields have not been filled, alert the user
            else
            {
                MessageBox.Show("Must enter required fields");
            }
        }

        // Back to main menu
        private void newPatient_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _hospital.Show();
        }

        // Mouse hover effects on button
        private void button1_newPatient_MouseEnter(object sender, EventArgs e)
        {
            button1_newPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button1_newPatient_MouseLeave(object sender, EventArgs e)
        {
            button1_newPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // Mouse hover effects on button
        private void newPatient_back_MouseEnter(object sender, EventArgs e)
        {
            newPatient_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void newPatient_back_MouseLeave(object sender, EventArgs e)
        {
            newPatient_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
