using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        //Instancer til klasser
        private Patient patient = new Patient();
        private Tandlæge tandlægeLige = new Tandlæge();
        private Tandlæge tandlægeUlige = new Tandlæge();

        //Når programmet starter putter den data i vores instancer
        public Form1()
        {
            InitializeComponent();
            tandlægeLige = new Tandlæge(Venteværelse_Listbox, Status_Listbox, numericUpDown2, textBox_Status, textBox_Patient, Start_Knap, patient);
            tandlægeUlige = new Tandlæge(Venteværelse_Listbox, Status_Listbox, numericUpDown3, TextBoxStatus2, textBox_Patient2, Start_Knap, patient);
            patient = new Patient(Venteværelse_Listbox, Status_Listbox, numericUpDown1, Start_Knap, this, tandlægeLige, textBox_Status, tandlægeUlige);
        }

        //Start/exit knap
        private void button1_Click(object sender, EventArgs e)
        {
            //Tråde
            Thread patientTråd = new Thread(patient.Opret_Ny_Patient);
            Thread tandlægeLigeTråd = new Thread(tandlægeLige.TandlægePåbegynd);
            Thread tandlægeUligeTråd = new Thread(tandlægeUlige.TandlægePåbegynd);
            tandlægeLige.TandlægeTråd = tandlægeLigeTråd;
            tandlægeUlige.TandlægeTråd = tandlægeUligeTråd;

            //Starter tråene
            if (Start_Knap.Text == "Start")
            {
                patientTråd.Start();
                tandlægeLigeTråd.Start();
                tandlægeUligeTråd.Start();
                Start_Knap.Text = "Exit";
            }
            else if (Start_Knap.Text == "Exit")
            {
                //Lukker programmet
                Application.ExitThread();
                Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}