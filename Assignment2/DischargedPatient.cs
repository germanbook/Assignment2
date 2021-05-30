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
    public partial class DischargedPatient : Form
    {
        Hospital _hospital;
        public DischargedPatient(Hospital hospital)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _hospital = hospital;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _hospital.Show();
            this.Hide();
        }

        public void ShowDischargedPatients()
        {
            List<Patient> p  = Functions.ShowDischargedPatients();
            listView1.Items.Clear();
            for (int i = 0; i < p.Count; i++)
            {
                listView1.Items.Add(p[i].ID);
                listView1.Items[i].SubItems.Add(p[i].Name);
                listView1.Items[i].SubItems.Add(p[i].Details);
                listView1.Items[i].SubItems.Add(p[i].Rfv);
                if (p[i].LongTerm == true)
                {
                    listView1.Items[i].SubItems.Add("Long Term");
                }
                else
                {
                    listView1.Items[i].SubItems.Add("Day Patietn");
                }
                listView1.Items[i].SubItems.Add(p[i].Doctor);
                listView1.Items[i].SubItems.Add("Discharged");


            }
            if (listView1.Items.Count == 0)
                listView1.Items.Add("No Data!");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
