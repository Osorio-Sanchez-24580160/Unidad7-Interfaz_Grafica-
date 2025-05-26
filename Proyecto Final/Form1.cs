using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();

            try
            {
                serialPort = new SerialPort();

                //PORT Selection ComboBox
                string[] availablePorts = SerialPort.GetPortNames();
                comboBoxPortSelection.DataSource = availablePorts;

                //baud Rate Speeds
                string[] rates = { "9600", "38400", "57600", "115200", "250000" };
                comboBoxBaudRate.DataSource = rates;

                //config some parameter for serial connection
                serialPort.Parity = Parity.None;
                serialPort.StopBits = StopBits.One;
                serialPort.DataBits = 8;
                serialPort.Handshake = Handshake.None;
                serialPort.ReadTimeout = 250;
                serialPort.WriteTimeout = 250;

                //start timer for digital clock
                timer1.Interval = 1000; //tick interval 1 sec
                timer1.Start();
                ;
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
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort.IsOpen)

                {
                    // change button UI  

                    buttonConnect.Text = "Disconnect";
                    buttonConnect.BackColor = Color.Red;


                    // change the status of the app 
                    ChangeAppStatusIndication(true);
                    OpenSerialPort();
                    // register event to receiver data 
                    serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                }
                else
                {
                    // change button UI 
                    buttonConnect.Text = "Connect";
                    buttonConnect.BackColor = Color.Green;
                    // change the status of the app 
                    ChangeAppStatusIndication(false);
                    // reset all the components to default state and also u can send a message to microcontroller to reset the components that need it
                    //ResetAppToDefaultState();
                    CloseSerialPort();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                // change button UI 
                buttonConnect.Text = "Connect";
                buttonConnect.BackColor = Color.Green;
                // change the status of the app 
                ChangeAppStatusIndication(false);
            }
        }
        private void OpenSerialPort()
        {
            try
            {
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort.PortName = comboBoxPortSelection.Text;
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    serialPort.WriteLine("");
                    serialPort.DiscardInBuffer();
                }
                    
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
                buttonConnect.Text = "Conectado";
                buttonConnect.BackColor = Color.GreenYellow;
                //labelAppStatus.Text = "Status:    Connected";
                //pictureBoxStatusLed.Image = Properties.Resources.GreenLed;
            }
            else
            {
                buttonConnect.Text = "Desconectado";
                buttonConnect.BackColor = Color.Green;
                //labelAppStatus.Text = "Status: Disconnected";
                //pictureBoxStatusLed.Image = Properties.Resources.RedLed;
            }
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serialPort.IsOpen && serialPort.BytesToRead > 0)
            {
                string line = serialPort.ReadLine();
                // ProcessDataFromArduino(line);
            }
        }
        private void CloseSerialPort()
        {
            serialPort.Close();
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

        private void SendSerialCommand(string command)
        {
            if (serialPort != null && serialPort.IsOpen) // Verificar que el puerto no sea null y esté abierto
            {
                serialPort.Write(command);
            }
            else
            {
                MessageBox.Show("El puerto está cerrado. Conéctalo antes de enviar datos.");
            }
        }

        // Modificación de los métodos de movimiento para llamar a SendSerialCommand
        private void btnFoward_Click(object sender, EventArgs e) => SendSerialCommand("f");
        private void btnBackward_Click(object sender, EventArgs e) => SendSerialCommand("b");
        private void btnLeft_Click(object sender, EventArgs e) => SendSerialCommand("L");
        private void btnRight_Click(object sender, EventArgs e) => SendSerialCommand("R");
        private void btnStop_Click(object sender, EventArgs e) => SendSerialCommand("S");
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Open();
            }
        }
    }
}
