using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreading
{
    public partial class Form1 : Form
    {
        //Instancer til klasser
        Patient P = new Patient();
        Tandlæge T = new Tandlæge();
        Tandlæge T2 = new Tandlæge();



        //Når programmet starter putter den data i vores instancer
        public Form1()
        {
          InitializeComponent();
            
          P = new Patient(Venteværelse_Listbox, Status_Listbox,numericUpDown1, Start_Knap);
          T = new Tandlæge(Venteværelse_Listbox,Status_Listbox, numericUpDown2,textBox_Status,textBox_Patient, Start_Knap );
          T2 = new Tandlæge(Venteværelse_Listbox, Status_Listbox, numericUpDown3, TextBoxStatus2, textBox_Patient2, Start_Knap);

        }



        //Start/exit knap
        private void button1_Click(object sender, EventArgs e)
        {
            //Tråde
            Thread t = new Thread(P.Opret_Ny_Patient);
            Thread t2 = new Thread(T.Tandæøge_Behandling);
            Thread t3 = new Thread(T2.Tandæøge_Behandling);
       
            //Starter tråene
            if (Start_Knap.Text == "Start")
            {

                t.Start();
                t2.Start();
                t3.Start();
                Start_Knap.Text = "Exit";
            }
            else if (Start_Knap.Text == "Exit")
            {
                //Lukker programmet
                Application.ExitThread();

                Environment.Exit(0);

            }


        }
    }
}
