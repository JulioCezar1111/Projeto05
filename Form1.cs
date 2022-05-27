using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PortaSerial
{
    public partial class Form1 : Form
    {
        string RxData;
        int A0,A1,A2,A3;
       
        delegate void ExecutaMetodo();

        public void teste()
        {
            if(tank1.Value >= 1000) { btnEM1.Value = true;}
            else { btnEM1.Value = false; }

            if (tank2.Value >= 1000) { btnEM2.Value = true; }
            else { btnEM2.Value = false; }

            if (tank3.Value >= 1000) { btnEM3.Value = true; }
            else { btnEM3.Value = false; }

            if (tank4.Value >= 1000) { btnEM4.Value = true; }
            else { btnEM4.Value = false; }
        }

        private void LeituraPortaSerial()
        {
            RxData = serialPort1.ReadLine();
            txbRxData.Text = RxData;
            String[] RxPacote = RxData.Split(':');
            A0 = int.Parse(RxPacote[0]);
            A1 = int.Parse(RxPacote[1]);
            A2 = int.Parse(RxPacote[2]);
            A3 = int.Parse(RxPacote[3]);
            txbA0.Text = A0.ToString();
            txbA1.Text = A1.ToString();
            txbA2.Text = A2.ToString();
            txbA3.Text = A3.ToString();
            tank1.Value = A0;
            tank2.Value = A1;
            tank3.Value = A2;
            tank4.Value = A3;
            teste();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region ConfigPorta
            string[] PortaCom = SerialPort.GetPortNames();
            string[] BaudRate = { "1200", "2400", "4800", "9600" };
            cbxPortCom.Items.AddRange(PortaCom);
            cbxBaudRate.Items.AddRange(BaudRate);
            
            #endregion
        }



        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
            else
            {
                serialPort1.PortName = cbxPortCom.Text;
                serialPort1.BaudRate = Convert.ToInt32(cbxBaudRate.Text);
                serialPort1.Open();
                btnDesconectar.Enabled = true;
                btnConectar.Enabled = false;
                pilotoCom.Value = true;
                pilotoCom.Text = "ON";
            }
        }

        private void btnDesconectar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                btnDesconectar.Enabled = false;
                btnConectar.Enabled = true;
                pilotoCom.Value = false;
                pilotoCom.Text = "OFF";
            }
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                this.Close();
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ExecutaMetodo obj_delegate = new ExecutaMetodo(LeituraPortaSerial);
            Invoke(obj_delegate);
        }

        private void btnEN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[SISTON]");
                pilotoSt.Value = true;
                pilotoSt.Text = "ON ";
            }
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write("[SISTOFF]");
                pilotoSt.Value = false;
                pilotoSt.Text = "OFF";
            }
        }
    }
}
