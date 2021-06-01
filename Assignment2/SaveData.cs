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
     * Save date form
     * Reminder user save data
     * 
     */
    public partial class SaveData : Form
    {
        Hospital _hospital;
        public SaveData(Hospital hospital)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _hospital = hospital;
            this.ControlBox = false;
        }

        // Save
        private void button1_Save_MouseClick(object sender, MouseEventArgs e)
        {
            Functions.SaveData();
            MessageBox.Show("Data saved !");
            this.Close();
            _hospital.Close();
        }

        // Exit
        private void button2_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            _hospital.Dispose();
        }

        // Mouse hover effects on button
        private void button1_Save_MouseEnter(object sender, EventArgs e)
        {
            button1_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }
        
        // Mouse hover effects on button
        private void button1_Save_MouseLeave(object sender, EventArgs e)
        {
            button1_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
        
        // Mouse hover effects on button
        private void button2_Exit_MouseEnter(object sender, EventArgs e)
        {
            button2_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button2_Exit_MouseLeave(object sender, EventArgs e)
        {
            button2_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
