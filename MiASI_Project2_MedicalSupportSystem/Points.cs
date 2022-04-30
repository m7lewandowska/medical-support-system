using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiASI_Project2_MedicalSupportSystem
{
    class Points
    {
        public int pregnancies { get; set; }
        public int glucose { get; set; }
        public int bloodPressure { get; set; }
        public int skinThickness { get; set; }
        public int insulin { get; set; }
        public float bmi { get; set; }
        public float diabetesPedigreeFunction { get; set; }
        public int age { get; set; }
        public int outcome { get; set; }
        public float score { get; set; }
        public Points() { }
        public Points(int pregnancies, int glucose, int bloodPressure, int skdecimalhickness, int insulin, float bmi, float diabetesPedigreeFunction, int age, int outcome)
        {
            this.pregnancies = pregnancies;
            this.glucose = glucose;
            this.bloodPressure = bloodPressure;
            this.skinThickness = skinThickness;
            this.insulin = insulin;
            this.bmi = bmi;
            this.diabetesPedigreeFunction = diabetesPedigreeFunction;
            this.age = age;
            this.outcome = outcome;
        }
    }
}
