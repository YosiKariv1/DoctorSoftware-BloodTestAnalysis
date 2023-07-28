using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorSoftware
{
    internal class Patient
    {
        public string name, lastName, id, sex;
        public bool fever, medicalSensivity, smoker, eastOriented, pregnet, ethipoian, diarriaAndVomiting;
        public int age;
        public Diagnoses diagnoses;
        //public Dictionary<string, string> Quetions = new Dictionary<string, string>();
        public List<string> diseases = new List<string>();
        public List<string> recommendation = new List<string>();


        public Patient(string name, string lastName, string id, string sex, int age, int wbc, int neut, int lymph, float rbc, int hct, int urea, float hb, float crtn, int iron, int hdl, int ap, bool fever, bool medicalSensivity, bool smoker, bool eastOriented, bool pregnet, bool ethipoian, bool diarriaAndVomiting)
        {
            this.name = name;
            this.lastName = lastName;
            this.id = id;
            this.sex = sex;
            this.age = age;
            this.fever = fever;
            this.medicalSensivity = medicalSensivity;
            this.smoker = smoker;
            this.eastOriented = eastOriented;
            this.pregnet = pregnet;
            this.ethipoian = ethipoian;
            this.diarriaAndVomiting = diarriaAndVomiting;
            diagnoses = new Diagnoses(this, wbc, neut, lymph, rbc, hct, urea, hb, crtn, iron, hdl, ap);
            diseases = diagnoses.patient.diseases;
            recommendation = diagnoses.patient.recommendation;
        }
    }
}
