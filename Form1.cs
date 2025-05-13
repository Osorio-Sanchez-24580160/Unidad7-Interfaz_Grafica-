using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                //start timer for the clock 
                timer1.Interval = 1000; //tick interval 1 sec
                timer1.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormApplication.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPortObject.IsOpen)
                {
                    // change button UI  
                    buttonConnect.Text = "Disconnect";
                    buttonConnect.ButtonColor = myRed;
                    buttonConnect.BorderColor = myRed;
                    // change the status of the app 
                    ChangeAppStatusIndication(true);
                    OpenSerialPort();
                    // register event to receiver data 
                    serialPortObject.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                }
                else
                {
                    // change button UI 
                    buttonConnect.Text = "Connect";
                    buttonConnect.ButtonColor = myGreen;
                    buttonConnect.BorderColor = myGreen;
                    // change the status of the app 
                    ChangeAppStatusIndication(false);
                    // reset all the components to default state and also u can send a message to microcontroller to reset the components that need it
                    ResetAppToDefaultState();
                    CloseSerialPort();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                // change button UI 
                buttonConnect.Text = "Connect";
                buttonConnect.ButtonColor = myGreen;
                buttonConnect.BorderColor = myGreen;
                // change the status of the app 
                ChangeAppStatusIndication(false);
            }
        }
        private void OpenSerialPort()
        {
            try
            {
                serialPortObject.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPortObject.PortName = comboBoxPortSelection.Text;
                serialPortObject.Open();
                serialPortObject.WriteLine("");
                serialPortObject.DiscardInBuffer();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void ChangeAppStatusIndication(bool turnOnStatus)
        {
            if (turnOnStatus)
            {
                labelAppStatus.Text = "Status:    Connected";
                pictureBoxStatusLed.Image = Properties.Resources.GreenLed;
            }
            else
            {
                labelAppStatus.Text = "Status: Disconnected";
                pictureBoxStatusLed.Image = Properties.Resources.RedLed;
            }
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPortObject.IsOpen && serialPortObject.BytesToRead > 0)
            {
                string line = serialPortObject.ReadLine();
                ProcessDataFromArduino(line);
            }
        }
        private void CloseSerialPort()
        {
            serialPortObject.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPortSelection.DataSource = ports;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPortSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
