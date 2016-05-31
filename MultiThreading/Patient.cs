using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreading
{
    public class Patient
    {
        //Variabler
        private ListBox venteværelse;
        private ListBox status;
        private NumericUpDown patientDelay;
        private Button knap;
        private bool patientAntalTjek = true;
        private int patientAntal;
        private string patient;
        private int patientnummer = 1;
        private string patientnavn;



        //Constructor
        public Patient(ListBox venteværelse, ListBox status, NumericUpDown patientDelay, Button knap)
        {
            this.venteværelse = venteværelse;
            this.patientDelay = patientDelay;
            this.status = status;
            this.knap = knap;
        }
        // Overload construcktor
        public Patient()
        {
          
        }




        //Udskriver patienterne til listboxen venteværelse
        public string Udskriv_Patient_Til_Venteværelse(string patientNavn,int patientNummer)
        {
           
            patient = String.Format("Patient: {0}", patientnummer.ToString());
            
            return patient;
        }





        // Holder styr på at der maks må være 10 personer i venteværelset
        // True = Der er plads til flere i venteværelset
        // False = Der er 10 patienter i venteværelset
        public bool Antal_Venteværelse()
        {
           // venteværelse.BeginInvoke((MethodInvoker)delegate () { patientAntal = venteværelse.Items.Count; });

            patientAntal = venteværelse.Items.Count;
            if (patientAntal == 10)
            {
                patientAntalTjek = false;
                return patientAntalTjek;
            }
            else
                return patientAntalTjek;
        }


        //Tilføj vilkårlig test til status listboxen
        private void TilføjTekstTilStatus(string Tekst)
        {

           status.BeginInvoke((MethodInvoker)delegate () { status.Items.Add(Tekst); });

        }


        //Tilføj vilkårlig test til venteværelse listboxen
        private void TilføjTekstTilVenteværelse(string tekst)
        {
            
                venteværelse.BeginInvoke((MethodInvoker)delegate () { this.venteværelse.Items.Add(tekst); });
        }


        //Sørger for at listboxen viser den sidste tilføjet
        private void Autoscrole()
        {
            status.BeginInvoke((MethodInvoker)delegate () { status.TopIndex = status.Items.Count - 1; });
        }


        // Opretter en patient til venteværelset
        public void Opret_Ny_Patient()
        {
            while (true)
            {
                // Bestemmer hastigheden
                Thread.Sleep(Convert.ToInt32(patientDelay.Value * 1000));

                // Tjekker om venteværelset er fuldt
                if (Antal_Venteværelse() == true)
                {
                    Antal_Venteværelse();
                    TilføjTekstTilStatus("Der er tilføjet en ny patient");
                    TilføjTekstTilVenteværelse(Udskriv_Patient_Til_Venteværelse(patientnavn, patientnummer));
                    patientnummer = patientnummer + 1;


                }
                else
                {

                    TilføjTekstTilStatus("Der er for mange patienter i venteværelset");
                    patientAntalTjek = true;
                }


                Autoscrole();
            }
            {
                



            }
        }
                
                
    }
}

