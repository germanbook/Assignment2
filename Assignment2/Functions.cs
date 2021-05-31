using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /**
    * Functions
    * Including some basics functions
    * 
    */
    public static class Functions
    {
        
        // Display day patients
        public static List<Patient> ShowDayPatients()
        {
            var dayPatients =
                from patient in Hospital.patients
                where patient.LongTerm == false
                select patient;

            List<Patient> dp = dayPatients.ToList();

            return dp;
        }

        // Display long-term patients
        public static List<Patient> ShowLongTermPatients()
        {
            var longTermPatient =
                from patient in Hospital.patients
                where patient.LongTerm == true
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

        // Display active patients
        public static List<Patient> ShowActivePatients()
        {
            var activePatients =
                from patient in Hospital.patients
                where patient.Discharged == false
                select patient;

            List<Patient> ap = activePatients.ToList();

            return ap;
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

    }
}
