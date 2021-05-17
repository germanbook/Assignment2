﻿using System;
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
    public partial class Hospital : Form
    {
        public static List<Patient> patients = new List<Patient>();

        public Hospital()
        {
            InitializeComponent();
        }

        // show long term patient
        private void button1_Click(object sender, EventArgs e)
        {
            LongTerm_Day_Patient patient = new LongTerm_Day_Patient(this);
            patient.Show();
            patient.ShowLongTermDayPatients(button1.Name);
            this.Hide();
            
        }

        // show day patient
        private void button2_Click(object sender, EventArgs e)
        {
            LongTerm_Day_Patient patient = new LongTerm_Day_Patient(this);
            patient.Show();
            patient.ShowLongTermDayPatients(button2.Name);
            this.Hide();
        }

        // new patient
        private void button3_Click(object sender, EventArgs e)
        {
            NewPatient newPatientForm = new NewPatient(this);
            this.Hide();
            newPatientForm.Show();
        }

        private void button4_UpdatePatient_Click(object sender, EventArgs e)
        {
            UpdatePatient  updatePatient = new UpdatePatient(this);
            this.Hide();
            updatePatient.Show();
            updatePatient.ShowAllPatients();
        }
    }
}
