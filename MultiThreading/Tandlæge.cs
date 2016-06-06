using System;
using System.Threading;
using System.Windows.Forms;

namespace MultiThreading
{
    public class Tandlæge
    {
        //Variabler
        private ListBox venteværelse;

        private ListBox listboxstatus;
        private TextBox textboxstatus;
        private TextBox textboxbehandling;
        private NumericUpDown tandlægedelay;
        private Button knap;
        private string færdigePatient;

        public Thread TandlægeTråd { get; set; }
        private static object listLocker = new object();

        public bool _go = true;
        private Patient patient;

        //Constructor
        public Tandlæge(ListBox venteværelse, ListBox listboxstatus, NumericUpDown tandlægedelay, TextBox textboxstatus,
            TextBox textboxbehandling, Button knap, Patient patient)
        {
            this.venteværelse = venteværelse;
            this.tandlægedelay = tandlægedelay;
            this.listboxstatus = listboxstatus;
            this.textboxstatus = textboxstatus;
            this.textboxbehandling = textboxbehandling;
            this.knap = knap;
            this.patient = patient;
        }

        // Overload construcktor
        public Tandlæge()
        {
        }

        //returnere hvilken patient der er færdig med behandling
        public string Udskriv_Færdige_Patient()
        {
            færdigePatient = String.Format("{0} er færdig med behandling", textboxbehandling.Text);
            return færdigePatient;
        }

        //Udskriver hvilke patient der vækker tandlægen og udskriver det til listbox status
        public void Udskriv_VækTandlæge()
        {
            venteværelse.Invoke((MethodInvoker)delegate ()
            {
                string VågnOp = String.Format("{0} vækker tandlægen", venteværelse.Items[0]);
                this.listboxstatus.BeginInvoke((MethodInvoker)delegate () { this.listboxstatus.Items.Add(VågnOp); });
            });
        }

        //Udskriver til listbox status hvem der bliver behandlet
        public void Udskriv_HvemDerBliverBehandlet()
        {
            venteværelse.Invoke((MethodInvoker)delegate ()
            {
                string BehandletPatint = String.Format("{0} bliver behandlet", venteværelse.Items[0]);
                this.listboxstatus.BeginInvoke(
                    (MethodInvoker)delegate () { this.listboxstatus.Items.Add(BehandletPatint); });
            });

            textboxbehandling.Invoke((MethodInvoker)delegate ()
           {
               textboxbehandling.BeginInvoke(
                   (MethodInvoker)delegate () { textboxbehandling.Text = venteværelse.Items[0].ToString(); });
           });
        }

        // Tilføjer tekst til listbox
        private void TilføjTekstTilTextboxBehandling(string Tekst)
        {
            textboxbehandling.BeginInvoke((MethodInvoker)delegate () { textboxbehandling.Text = (Tekst); });
        }

        //Tilføjer tekst til listboxStatus
        private void TilføjTekstTilListboxStatus(string Tekst)
        {
            listboxstatus.BeginInvoke((MethodInvoker)delegate () { listboxstatus.Items.Add(Tekst); });
        }

        //Tilføjer tekst til textboxStatus
        private void TilføjTekstTilTextboxStatus(string Tekst)
        {
            textboxstatus.BeginInvoke((MethodInvoker)delegate () { textboxstatus.Text = (Tekst); });
        }

        //Sørger for at listboxen altid viser den sidste ting skrevet
        private void Autoscrole()
        {
            listboxstatus.BeginInvoke(
                (MethodInvoker)delegate () { listboxstatus.TopIndex = listboxstatus.Items.Count - 1; });
        }

        // Tager patient fra venteværelset og behandler ham
        public void TandlægePåbegynd() // Metode som tandlæge trådende bruger
        {
            while (_go) // _go er en bool
            {
                bool locked = false; // Bruges til monitor.tryenter for at sikre sig at der kun er en tråd som kan få adgang

                Thread.Sleep(Convert.ToInt32(tandlægedelay.Value * 1000));  //  Bestemmer hastigheden for tandlægerne

                try
                {
                    Monitor.TryEnter(venteværelse, ref locked); // Her sørger den for at kun en tråd kan bruge venteværelset afgangen

                    if (locked)
                    {
                        if (venteværelse.Items.Count == 0) // Hvis der ikke er nogle i venteværelset
                        {
                            TilføjTekstTilListboxStatus("Ingen patienter i venteværelset");
                            TilføjTekstTilTextboxStatus("Sover");
                            TilføjTekstTilTextboxBehandling("");
                            _go = false;
                        }
                        else if (venteværelse.Items.Count >= 1) // Hvis der er nogle i venteværeset
                        {
                            if (textboxbehandling.Text != "")
                            {
                                TilføjTekstTilListboxStatus(Udskriv_Færdige_Patient()); // Udskriver at patienten er færdig med behandling
                            }

                            TilføjTekstTilTextboxStatus("Arbejder");
                            Udskriv_HvemDerBliverBehandlet(); // Udskriver hvem der har sat sig i tandlæge stolen
                            venteværelse.Invoke((MethodInvoker)delegate ()
                            {
                                venteværelse.Items.RemoveAt(venteværelse.TopIndex); // Fjerner den patient der bliver behandlet fra venteværelset
                            });
                        }
                    }
                }
                finally
                {
                    Autoscrole(); // Sørger for at listboxen altid viser det sidste der er sket
                    if (locked)
                    {
                        Monitor.Exit(venteværelse); // gør det muligt for en ny tråd at få adgang til venteværelset
                    }
                }

                while (!_go) // Hvis der ikke er folk i venteværelet
                {
                    lock (this)
                    {
                        TilføjTekstTilListboxStatus("Tandlæge tråd lægger sig til at sove...");
                        Monitor.Wait(this); // Ligger tråden til at sove
                        _go = true;
                    }
                }
            }
        }
    }
}