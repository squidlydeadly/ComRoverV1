using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComRoverV1
{
    public partial class Form1 : Form
    {
        public SerialPort myPort;
        public Form1()
        {
         

            InitializeComponent();

            ButtonsDisable();
           
        }
        public void init()
        {
            try
            {
                myPort = new SerialPort();
                myPort.BaudRate = 57600;
              //  myPort.PortName = "COM3";
                myPort.PortName = String.Concat("COM", comPortBox.Text );
                myPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                myPort.Open();

                ButtonsEnable();
                buttonGo.Enabled = false;
                MessageBox.Show("Connexion réussi !");
            }

            catch (Exception)
            {
                MessageBox.Show("Erreur ! Impossible de se connecter sur le port");
            }
          
        }
        private void ButtonsDisable()
        {
            buttonUp.Enabled = false;
            buttonDown.Enabled = false;
            buttonRight.Enabled = false;
            buttonLeft.Enabled = false;
            buttonStop.Enabled = false;
            buttonGo.Enabled = true;

        }

        private void ButtonsEnable()
        {
            buttonUp.Enabled = true;
            buttonDown.Enabled = true;
            buttonRight.Enabled = true;
            buttonLeft.Enabled = true;
            buttonStop.Enabled = true;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelStaticDistance_Click(object sender, EventArgs e)
        {

        }
   
        private void buttonStop_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("z");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("d");
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("w");
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("a");
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            myPort.WriteLine("s");
        }

        private void comPortBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            init();
           


        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.Close();
            }
            catch
            {

            }
            ButtonsDisable();
            buttonGo.Enabled = true;
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            NewMethod(indata);
           
        }

        public void NewMethod(string indata)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {

                serialDistanceValue.Text = indata;//.ToString();
            }));

         
        }

        private void labelCOMPortNumber_Click(object sender, EventArgs e)
        {

        }

        private void serialDistanceValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.W)
            {
                try
                {
                    myPort.WriteLine("w");
                }
                catch
                {

                }
           
            }

            if (e.KeyValue == (char)Keys.A)
            {
                try
                {
                    myPort.WriteLine("a");
                }
                catch
                {

                }

            }
            if (e.KeyValue == (char)Keys.D)
            {
                try
                {
                    myPort.WriteLine("d");
                }
                catch
                {

                }


            }
            if (e.KeyValue == (char)Keys.S)
            {
                try
                {
                    myPort.WriteLine("s");
                }
                catch
                {

                }

            }
            if (e.KeyValue == (char)Keys.C)
            {
                try
                {
                    myPort.WriteLine("z");
                }
                catch
                {

                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
