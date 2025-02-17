﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Assignment2
{
    /**
    * Functions
    * Including some basics functions
    * 
    */
    public static class Functions
    {
        const string path = @"../../datafile/Data.csv";
        // Display day patients
        public static List<Patient> ShowDayPatients()
        {
            var dayPatients =
                from patient in Hospital.patients
                where patient.LongTerm == false && patient.Discharged == false
                select patient;

            List<Patient> dp = dayPatients.ToList();

            return dp;
        }

        // Display long-term patients
        public static List<Patient> ShowLongTermPatients()
        {
            var longTermPatient =
                from patient in Hospital.patients
                where patient.LongTerm == true && patient.Discharged == false
                select patient;

            List<Patient> lp = longTermPatient.ToList();

            return lp;
        }

        // Display discharged patients
        public static List<Patient> ShowDischargedPatients()
        {
            var dischargedPatients =
                from patient in Hospital.patients
                where patient.Discharged == true
                select patient;

            List<Patient> dcp = dischargedPatients.ToList();

            return dcp;
        }

        // Display all patients
        public static List<Patient> ShowAllPatients()
        {
            var dayPatients =
                from patient in Hospital.patients
                select patient;

            List<Patient> dp = dayPatients.ToList();

            return dp;
        }

        // Display patients by ID
        public static List<Patient> ShowPatientsByID(string id)
        {
            var patients = 
                from patient in Hospital.patients
                where patient.ID.Contains(id)
                select patient;

            List<Patient> p = patients.ToList();

            return p;
        }

        // LoadingData from csv file
        public static List<Patient> LoadingData()
        {
            List<Patient> p = new List<Patient>();
            try
            {

                string[] lines = System.IO.File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] info = line.Split(',');

                    p.Add(new Patient(info[0],
                                      info[1],
                                      info[2],
                                      info[3],
                                      Convert.ToBoolean(info[4]),
                                      Convert.ToBoolean(info[5]),
                                      info[6]
                                      )
                         );
                }
                
            } 
            catch
            {
                MessageBox.Show("Data File not found");
                System.Diagnostics.Process process
                    = System.Diagnostics.Process.GetProcessById(System.Diagnostics.Process.GetCurrentProcess().Id);
                process.Kill();
            }
            return p;
        }
        
        // Compare whether the existing data is the same as the stored data
        public static bool IfDataSame()
        {
            bool b = Functions.LoadingData().All(Hospital.patients.Contains);
            return b;
        }

        // Store data to csv file
        public static void SaveData()
        {

            try
            {

                FileStream stream = new FileStream(path, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.UTF8);

                for (int i = 0; i < Hospital.patients.Count; i++)
                {
                    string dataStr = string.Empty;
                    dataStr += Hospital.patients[i].ID.ToString() + ",";
                    dataStr += Hospital.patients[i].Name.ToString() + ",";
                    dataStr += Hospital.patients[i].Details.ToString() + ",";
                    dataStr += Hospital.patients[i].Rfv.ToString() + ",";
                    dataStr += Hospital.patients[i].LongTerm.ToString() + ",";
                    dataStr += Hospital.patients[i].Discharged.ToString() + ",";
                    dataStr += Hospital.patients[i].Doctor.ToString();
                    writer.WriteLine(dataStr);
                }
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Data File not found");
            }

        }
    }
}
