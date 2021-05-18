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
    public partial class UpdatePatient : Form
    {
        Hospital _hospital;
        public UpdatePatient(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;
        }

        private void listView1_UpdatePatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _hospital.Show();
            this.Hide();
        }

        public void ShowAllPatients()
        {
            List<Patient> p = new List<Patient>();
            p = Functions.ShowAllPatients();
            this.ShowPatientsListview(p);
            
        }

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
                    listView1_UpdatePatient.Items[i].SubItems.Add("Day Patietn");
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

        private void textBox1_searchByNameOrID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13)
            {
                return;
            }
            else
            {
                List<Patient> p = new List<Patient>();
                p = Functions.ShowPatientsByNameOrID(textBox1_searchByNameOrID.Text);
                if (p.Count != 0)
                {
                    this.ShowPatientsListview(p);
                }
                else
                {
                    this.ShowAllPatients();
                }
                
            }
        }

    }
}
