using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ovning3_Edwar
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private float height;
        private float weight;

        // proporty for Age, FName, LName, Height, Weight
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value must be greater than  0, by teacher");
                }
                else
                {
                    age = value;
                }
            }
        }
        public void SetAge(int value)
        {
            Age = value;
        }
        public int GetAge()
        {
            return Age;
        }
        public string Fname
        {
            get
            {
                return fName;
            }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("the fName should be larger than 2 and less than 10 characters");
                }
                else
                    Fname = value;
            }
        }
        public void SetFname(string value)
        {
            Fname = value;
        }

        public string GetFname()
        {
            return fName;
        }
        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("the LName should be larger than 3 and less than 15 characters");
                }
                else
                    lName = value;
            }
        }
        public void Setlname(string value)
        {
            lName = value;
        }
        public string Getlname()
        {
            return lName;
        }
        public double Height { get; set; }
        public double Weight { get; set; }
    }
}


