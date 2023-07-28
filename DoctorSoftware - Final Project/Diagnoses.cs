
namespace DoctorSoftware
{

    internal class Diagnoses
    {
        public Patient patient;
        public int wbc, neut, lymph, hct, urea, iron, hdl, ap;
        public float rbc, hb, crtn;

        public Diagnoses(Patient patient, int wbc, int neut, int lymph, float rbc, int hct, int urea, float hb, float crtn, int iron, int hdl, int ap)
        {
            this.patient = patient;
            this.wbc = wbc;
            this.neut = neut;
            this.lymph = lymph;
            this.rbc = rbc;
            this.hct = hct;
            this.urea = urea;
            this.hb = hb;
            this.crtn = crtn;
            this.iron = iron;
            this.hdl = hdl;
            this.ap = ap;
            ApplyDiagnoses();

        }
        public void ApplyDiagnoses()
        {
            Anemia();
            Diet();
            bleeding();
            Hyperlipidemia();
            DisorderOfBloodCellFormation();
            MutologicalDisorder();
            IronPoisoning();
            Dehydration();
            Infection();
            VitaminDeficiency();
            ViralDisease();
            DiseasesOfTheBiliaryTract();
            HeartDiseases();
            BloodDisease();
            LiverDisease();
            KidneyDisease();
            IronDeficiency();
            MuscleDiseases();
            Smoker();
            Hyperthyroidism();
            DiabetesForAdults();
            Cancer();
            IncreasedConsumptionOfMeat();
            UseOfVariousMedications();
            Malnutrition();
        }

        public void Anemia()
        {
            if (rbc < 4.5 || patient.sex == "Male" && hct < 37 || patient.sex == "Famle" && hct < 33 || patient.age <= 17 && hb < 11.5 || patient.age > 17 && hb < 12)
            {
                patient.diseases.Add("Anemia");
                patient.recommendation.Add("Two 10 mg B12 pills a day for a month");
            }

        }

        public void Diet()
        {
            if (patient.eastOriented && urea > 47.3 || !patient.eastOriented && urea > 43 && patient.eastOriented && urea < 18.7 || !patient.eastOriented && urea < 17)
            {
                if (patient.sex == "Male" && iron < 60 || patient.sex == "Female" && iron < 48)
                {
                    patient.diseases.Add("Diet");
                    patient.recommendation.Add("Schedule an appointment with a nutritionist");

                }

                if (patient.pregnet)
                {
                    patient.recommendation.Add("As a result of pregnancy the level of urination decreases");

                }
            }

        }
        public void bleeding()
        {
            if (patient.sex == "Female" && hct < 33 && iron < 48 || patient.sex == "Male" && hct < 33 && iron < 60 || patient.age <= 17 && hb < 11.5 || patient.age > 17 && hb < 12 || rbc < 4.5)
            {
                patient.diseases.Add("bleeding");
                patient.recommendation.Add("To be rushed to the hospital urgently");
            }

        }

        public void Hyperlipidemia()
        {
            if (patient.ethipoian && hdl < 34.8 && patient.sex == "Male" || !patient.ethipoian && hdl < 40.8 && patient.sex == "Female" || patient.sex == "Male" && hdl < 29 || patient.sex == "Female" && hdl < 34)
            {
                patient.diseases.Add("Hyperlipidemia");
                patient.recommendation.Add("Schedule an appointment with a nutritionist, a 5 mg pill of Simobil daily for a week");
            }

        }

        public void DisorderOfBloodCellFormation()
        {
            if (neut < 28 || lymph < 36 || rbc > 6)
            {
                patient.diseases.Add("Disorder Of Blood Cell Formation");
                patient.recommendation.Add("10 mg pill of B12 a day for a month 5 mg pill of folic acid a day for a month");
            }
        }

        public void MutologicalDisorder()
        {
            if (patient.age <= 17 && hb < 11.5 || patient.age > 17 && hb < 12)
            {
                patient.diseases.Add("Mutological Disorder");
                patient.recommendation.Add("An injection of a hormone to encourage red blood cell production");
            }
        }

        public void IronPoisoning()
        {
            if (patient.sex == "Male" && iron > 160 || patient.sex == "Female" && iron > 128)
            {
                patient.diseases.Add("Iron Poisoning");
                patient.recommendation.Add("To be evacuated to the hospital");
            }
        }

        public void Dehydration()
        {
            if (patient.eastOriented && urea > 47.3 || !patient.eastOriented && urea > 43)
            {
                patient.diseases.Add("Dehydration");
                patient.recommendation.Add("Complete rest while lying down, returning fluids to drinking");
            }
        }

        public void Infection()
        {
            if (patient.age >= 17 && wbc > 11000 || (patient.age >= 4 || patient.age <= 17) && wbc > 15500 || patient.age <= 3 && wbc > 17500 || neut > 54 || neut < 28 || lymph > 52)
            {
                patient.diseases.Add("Infection");
                patient.recommendation.Add("Dedicated antibiotics");
            }
        }

        public void VitaminDeficiency()
        {
            if (patient.eastOriented && ap < 60 || !patient.eastOriented && ap < 30)
            {
                patient.diseases.Add("Vitamin Deficiency");
                patient.recommendation.Add("Referral for a blood test to identify the missing vitamins");
            }
        }

        public void ViralDisease()
        {
            if(patient.age <= 2 && crtn > 0.5 || patient.age <= 2 && wbc < 6000 || (patient.age >= 3 || patient.age <= 17) && crtn > 1 || (patient.age >= 3 || patient.age <= 17) && wbc < 5500 || (patient.age >= 17 || patient.age <= 59) && crtn > 1 || (patient.age >= 17 || patient.age <= 59)  && wbc < 4500 || patient.age >= 60 && crtn > 1.2 || patient.age >= 60 && wbc < 4500)
            {
                patient.diseases.Add("Viral Disease");
                patient.recommendation.Add("Rest at home");
            }
        }

        public void DiseasesOfTheBiliaryTract()
        {
            
            if (patient.eastOriented && !patient.pregnet && ap > 120 || !patient.eastOriented && !patient.pregnet && ap > 90)
            {
                patient.diseases.Add("Diseases Of The Biliary Tract");
                patient.recommendation.Add("Referral to surgical treatment");
            }
        }

        public void HeartDiseases()
        {
            if (patient.ethipoian && patient.sex == "Male" && hdl < 34.8 || patient.ethipoian && patient.sex == "Female" && hdl < 40.8 || patient.sex == "Male" && hdl < 29 || patient.sex == "Female" && hdl < 34)
            {
                patient.diseases.Add("Heart Diseases");
                patient.recommendation.Add("Schedule an appointment with a nutritionist");
            }
        }

        public void BloodDisease()
        {
            if(patient.age >= 18 && wbc > 11000 || (patient.age >= 4 || patient.age <= 17) && wbc > 15500 || patient.age >= 3 && wbc >17500)
            {
                patient.diseases.Add("Blood Disease");
                patient.recommendation.Add("A combination of cyclophosphamide and corticosteroids");
            }
        }

        public void LiverDisease()
        {
            if (patient.eastOriented)
            {
                if (urea < 18.7 || ap > 120 && !patient.pregnet)
                {
                    patient.diseases.Add("LiverDisease");
                    patient.recommendation.Add("Referral to a specific diagnosis for the purpose of determining treatment");

                    if (patient.pregnet)
                    {
                        patient.recommendation.Add("As a result of pregnancy the level of urination decreases");

                    }
                }
            }
            else if (!patient.eastOriented)
            {
                if (urea < 17 || ap > 90 && !patient.pregnet)
                {
                    patient.diseases.Add("LiverDisease");
                    patient.recommendation.Add("Referral to a specific diagnosis for the purpose of determining treatment");

                    if (patient.pregnet)
                    {
                        patient.recommendation.Add("As a result of pregnancy the level of urination decreases");

                    }
                }

            }
        }

        public void KidneyDisease()
        {
            if(patient.eastOriented && urea > 47.3 || !patient.eastOriented && urea > 43 || patient.age >= 2 && crtn > 0.5 || (patient.age >= 3 || patient.age <= 17) && crtn > 1 || (patient.age >= 18 || patient.age <= 59) && crtn > 1 || patient.age >= 60 && crtn > 1.2)
            {
                patient.diseases.Add("Kidney Disease");
                patient.recommendation.Add("Balance blood sugar levels");
            }

        }

        public void IronDeficiency()
        {
            if (patient.age <= 17 && hb < 11.5 || patient.age >= 17 && hb < 12)
            {
                patient.diseases.Add("Iron Deficiency");
                patient.recommendation.Add("Two 10 mg B12 pills a day for a month");

            }
        }

        public void MuscleDiseases()
        {
            if(patient.age < 2 && crtn < 0.2 || (patient.age >= 3 || patient.age >= 17) && crtn < 0.5 || (patient.age >= 18 || patient.age >= 59) && crtn < 0.6 || patient.age >= 60  && crtn < 0.6)
            {
                patient.diseases.Add("Muscle Diseases");
                patient.recommendation.Add("Two 5 mg pills of Altman c3 turmeric a day for a month");
            }

        }

        public void Smoker()
        {
            if (patient.sex == "Male" && hct > 47 || patient.sex == "Female" && hct > 54 || rbc > 6)
            {
                patient.recommendation.Add("Recommend smoking cessation");

                if (rbc > 6)
                {
                    patient.diseases.Add("Lung Disease");
                    patient.recommendation.Add("Referral for an X-ray of the lungs");
                }
            }
        }

        public void Hyperthyroidism()
        {
            if (!patient.pregnet)
            {
                if (patient.eastOriented && ap > 120 || !patient.eastOriented && ap > 90)
                {
                    patient.diseases.Add("Hyperthyroidism");
                    patient.recommendation.Add("ropylthiouracil to reduce thyroid activity");
                }
            }
        }

        public void DiabetesForAdults()
        {
            if (patient.ethipoian && patient.sex == "Male" && hdl < 34.8 || patient.ethipoian && patient.sex == "Female" && hdl < 40.8 || patient.sex == "Male" && hdl < 29 || patient.sex == "Female" && hdl < 34)
            {
                patient.diseases.Add("Diabetes For Adults");
                patient.recommendation.Add("Insulin adjustment for the patient");
            }

        }

        public void Cancer()
        {

            if (patient.age >= 18 && (wbc > 11000 || wbc < 4500) || (patient.age >= 4 || patient.age <= 17) && (wbc > 15000 || wbc > 5500) || patient.age >= 3 && (wbc > 17500 || wbc < 6000) || neut > 28 || lymph > 52)
            {
                patient.diseases.Add("Rare cases of cancer");
                patient.recommendation.Add("Entrectinib");
            }
        }

        public void IncreasedConsumptionOfMeat()
        {
            if(patient.age > 2 && crtn > 0.5 || (patient.age >= 3 || patient.age <= 17) && crtn > 1 || (patient.age >= 18 || patient.age <= 59) && crtn > 1 || patient.age >= 60 && crtn > 1.2)
            {
                patient.diseases.Add("Increased Consumption Of Meat");
                patient.recommendation.Add("Schedule an appointment with a nutritionist");
            }
        }

        public void UseOfVariousMedications()
        {
            if (patient.eastOriented && ap > 120 || !patient.eastOriented && ap > 90)
            {
                if (!patient.pregnet)
                {
                    patient.diseases.Add("Use Of Various Medications");
                    patient.recommendation.Add("Referral to a family doctor for a match between medications");
                }
            }
        }

        public void Malnutrition()
        {
            if(patient.eastOriented && urea < 18.7 || !patient.eastOriented && urea < 17)
            {
                patient.diseases.Add("Malnutrition");
                patient.recommendation.Add("Schedule an appointment with a nutritionist");

                if (patient.pregnet)
                {
                    patient.recommendation.Add("As a result of pregnancy the level of urination decreases");
                }

            }
            else if(patient.age > 2 && crtn < 0.2 || (patient.age >= 3 || patient.age <= 17) && crtn < 0.5 || (patient.age >= 18 || patient.age <= 59) && crtn < 0.6 || patient.age >= 60 && crtn < 0.6)
            {
                patient.diseases.Add("Malnutrition");
                patient.recommendation.Add("Referral to a family doctor for a match between medications");
            }

        }








    }
}
