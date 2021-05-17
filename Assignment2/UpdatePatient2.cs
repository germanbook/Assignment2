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
    public partial class UpdatePatient2 : Form
    {
        UpdatePatient _updatePatient;
        public UpdatePatient2(UpdatePatient patient)
        {
            InitializeComponent();
            _updatePatient = patient;
        }

        public void ShowSelectedPatient(int index)
        {
            List<Patient> p = new List<Patient>();
            p = Functions.ShowAllPatients();
            textBox1.Text = p[index].Name;
            textBox2.Text = p[index].Details;
            textBox3.Text = p[index].Rfv;
            textBox4.Text = p[index].Doctor;
            if (p[index].LongTerm == true)
            {
                radioButton2_longTermPatient.Checked = true;
            }
            else
            {
                radioButton1_dayPatient.Checked = true;
            }
            if (p[index].Discharged == true)
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
            
        }

        private void button2_back_Click(object sender, EventArgs e)
        {
            _updatePatient.Show();
            this.Hide();
        }
    }
}
