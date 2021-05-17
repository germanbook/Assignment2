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
    public partial class NewPatient : Form
    {
        Hospital _hospital;
        public NewPatient(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient(name.Text, details.Text, rfv.Text, radioButton2_longTermPatient.Checked, false, textBox1_doctor.Text);
            Hospital.patients.Add(newPatient);

            MessageBox.Show("Patient has been added!");
        }

        private void newPatient_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _hospital.Show();
        }
    }
}
