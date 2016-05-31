using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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




        //Constructor
        public Tandlæge(ListBox venteværelse, ListBox listboxstatus, NumericUpDown tandlægedelay, TextBox textboxstatus,
            TextBox textboxbehandling, Button knap)
        {
            this.venteværelse = venteværelse;
            this.tandlægedelay = tandlægedelay;
            this.listboxstatus = listboxstatus;
            this.textboxstatus = textboxstatus;
            this.textboxbehandling = textboxbehandling;
            this.knap = knap;
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
            venteværelse.Invoke((MethodInvoker) delegate()
            {
                string VågnOp = String.Format("{0} vækker tandlægen", venteværelse.SelectedItem.ToString());
                this.listboxstatus.BeginInvoke((MethodInvoker) delegate() { this.listboxstatus.Items.Add(VågnOp); });

            });
        }

        //Udskriver til listbox status hvem der bliver behandlet
        public void Udskriv_HvemDerBliverBehandlet()
        {
            venteværelse.Invoke((MethodInvoker) delegate()
            {
                string BehandletPatient = String.Format("{0} bliver behandlet", venteværelse.SelectedItem.ToString());
                this.listboxstatus.BeginInvoke(
                    (MethodInvoker) delegate() { this.listboxstatus.Items.Add(BehandletPatient); });

            });

            textboxbehandling.Invoke((MethodInvoker) delegate()
            {
                textboxbehandling.BeginInvoke(
                    (MethodInvoker) delegate() { textboxbehandling.Text = venteværelse.SelectedItem.ToString(); });

            });
        }

        // Tilføjer tekst til textboxBehanding
        private void TilføjTekstTilTextboxBehandling(string Tekst)
        {

            textboxbehandling.BeginInvoke((MethodInvoker) delegate() { textboxbehandling.Text = (Tekst); });

        }

        //Tilføjer tekst til textboxBehandling
        private void TilføjTekstTilListboxStatus(string Tekst)
        {

            listboxstatus.BeginInvoke((MethodInvoker) delegate() { listboxstatus.Items.Add(Tekst); });

        }

        //Tilføjer tekst til textboxStatus
        private void TilføjTekstTilTextboxStatus(string Tekst)
        {

            textboxstatus.BeginInvoke((MethodInvoker) delegate() { textboxstatus.Text = (Tekst); });

        }

        //Sørger for at listboxen altid viser den sidste ting skrevet
        private void Autoscrole()
        {
            listboxstatus.BeginInvoke(
                (MethodInvoker) delegate() { listboxstatus.TopIndex = listboxstatus.Items.Count - 1; });
        }

 


        // Tager patient fra venteværelset og behandler ham
        public void Tandæøge_Behandling()
        {
           while(true)
                {
                bool locked = false;
                //  Bestemmer hastigheden
                Thread.Sleep(Convert.ToInt32(tandlægedelay.Value * 1000));

                    try
                    {
                        Monitor.Enter(venteværelse, ref locked);

                        if (locked)
                        {


                            if (venteværelse.Items.Count == 0)
                            {

                                TilføjTekstTilListboxStatus("Ingen patienter i venteværelset");
                                TilføjTekstTilTextboxStatus("Sover");
                                TilføjTekstTilTextboxBehandling("");

                            }
                            else if (venteværelse.Items.Count >= 1)
                            {
                                if (textboxbehandling.Text != "")
                                {

                                    TilføjTekstTilListboxStatus(Udskriv_Færdige_Patient());
                                }
                                else if (textboxstatus.Text == "Sover" && venteværelse.Items.Count != 0)
                                {
                               
                                    venteværelse.BeginInvoke(
                                        (MethodInvoker) delegate() { venteværelse.SetSelected(0, true); });
                                    Udskriv_VækTandlæge();
                                }
                                TilføjTekstTilTextboxStatus("Arbejder");
                                venteværelse.BeginInvoke(
                                    (MethodInvoker) delegate() { venteværelse.SetSelected(0, true); });
                                Udskriv_HvemDerBliverBehandlet();
                                venteværelse.BeginInvoke(
                                    (MethodInvoker) delegate() { venteværelse.Items.RemoveAt(venteværelse.TopIndex); });
                            }

                        }


                    }
                    catch 
                    {
                        MessageBox.Show("fejl");   
                    }
                    finally
                    {
                    Autoscrole();
                    Monitor.Exit(venteværelse);
                }
                }
            }
            



        }






    }
