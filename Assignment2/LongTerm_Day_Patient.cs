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
    public partial class LongTerm_Day_Patient : Form
    {
        Hospital _hospital;
        public LongTerm_Day_Patient(Hospital hospital)
        {
            InitializeComponent();
            _hospital = hospital;
        }

        public void ShowLongTermDayPatients(string button)
        {
            List<Patient> p = new List<Patient>();
            listView1_Patients.Items.Clear();
            if (button == "button1")
            {
                p = Functions.ShowLongTermPatients();
            } 
            else if (button == "button2")
            {
                p = Functions.ShowDayPatients();
            }
            for (int i = 0; i < p.Count; i++)
            {
                listView1_Patients.Items.Add(p[i].Name);
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

        private void button1_Click(object sender, EventArgs e)
        {
            _hospital.Show();
            this.Hide();
        }
    }
}
