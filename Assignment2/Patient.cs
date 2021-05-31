using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    /**
     * Patient Class
     * Patient Fields and constructors
     * 
     */
    public class Patient
    {
        public string ID { set; get; }
        public string Name { set; get; }
        public string Details { set; get; }
        public string Rfv { set; get; }
        public bool LongTerm { set; get; }
        public bool Discharged { set; get; }
        public string Doctor { set; get; }

        // Default constructors
        public Patient() { }

        // Parameterized constructor
        public Patient(string n, string d, string r, bool longterm, bool discharged, string doc)
        {
            ID = DateTime.Now.ToString("ddMMyyyyHHmmss");
            Name = n;
            Details = d;
            Rfv = r;
            LongTerm = longterm;
            Discharged = discharged;
            Doctor = doc;
        }

        // Parameterized constructor for data loading
        public Patient(string id, string n, string d, string r, bool longterm, bool discharged, string doc)
        {
            ID = id;
            Name = n;
            Details = d;
            Rfv = r;
            LongTerm = longterm;
            Discharged = discharged;
            Doctor = doc;
        }

        // Override Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Patient p = obj as Patient;
            if (p == null)
            {
                return false;
            }
            else
            {
                return Equals(p);
            }
                
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return ID.GetHashCode() ^ Name.GetHashCode();
        }

        // Recall Equals
        public bool Equals(Patient p)
        {
            if (p == null)
            {
                return false;
            } 
            return (
                    this.ID == p.ID &&
                    this.Name == p.Name &&
                    this.Details == p.Details &&
                    this.Rfv == p.Rfv &&
                    this.LongTerm == p.LongTerm &&
                    this.Discharged == p.Discharged &&
                    this.Doctor == p.Doctor
                    );
        }

    }   
}
