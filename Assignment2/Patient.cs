﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Patient
    {
        public string Name { set; get; }
        public string Details { set; get; }
        public string Rfv { set; get; }
        public bool LongTerm { set; get; }
        public bool Discharged { set; get; }
        public string Doctor { set; get; }

        public Patient() { }

        public Patient( string n, string d, string r, bool longterm, bool discharged, string doc)
        {
            Name = n;
            Details = d;
            Rfv = r;
            LongTerm = longterm;
            Discharged = discharged;
            Doctor = doc;
        }
    }
}
