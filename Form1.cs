using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARDUINOBTCONTROL
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            serialPortNameCB.DataSource = SerialPort.GetPortNames();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Disconnect();
            }
            else
            {
                Connect();
            }
            
        }

        private void Disconnect()
        {
            serialPort1.Close();
            QCommand.Enabled = true;
            WCommand.Enabled = true;
            ECommand.Enabled = true;
            ACommand.Enabled = true;
            SCommand.Enabled = true;
            DCommand.Enabled = true;
            Q.Enabled = false;
            W.Enabled = false;
            E.Enabled = false;
            A.Enabled = false;
            S.Enabled = false;
            D.Enabled = false;
            ConnectButton.Text = "Подключиться";
        }

        private void Connect()
        {
            serialPort1.PortName = serialPortNameCB.SelectedItem.ToString();
            serialPort1.Open();
            QCommand.Enabled = false;
            WCommand.Enabled = false;
            ECommand.Enabled = false;
            ACommand.Enabled = false;
            SCommand.Enabled = false;
            DCommand.Enabled = false;
            Q.Enabled = true;
            W.Enabled = true;
            E.Enabled = true;
            A.Enabled = true;
            S.Enabled = true;
            D.Enabled = true;
            ConnectButton.Text = "Отключиться";
        }

        void SendCommand(TextBox commandTextBox)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(commandTextBox.Text);
            }
            else
            {
                MessageBox.Show("Не удалось подключиться к последовательному порту. Убедитесь, что порт еще доступен, обновите список и выберите порт в списке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Q_MouseDown(object sender, MouseEventArgs e)
        {
            SendCommand(QCommand);
        }

        private void W_MouseDown(object sender, MouseEventArgs e)
        {
            SendCommand(WCommand);
        }

        private void E_MouseDown(object sender, MouseEventArgs e)
        {
            SendCommand(ECommand);
        }

        private void A_MouseDown(object sender, MouseEventArgs e)
        {
            SendCommand(ACommand);
        }

        private void S_MouseDown(object sender, MouseEventArgs e)
        {
            SendCommand(SCommand);
        }

        private void D_MouseDown(object sender, MouseEventArgs e)
        {
            SendCommand(DCommand);
        }

        private void ControlMouseUp(object sender, MouseEventArgs e)
        {
            SendCommand(STOPCommand);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            switch (e.KeyCode)
            {
                case Keys.Q:
                    SendCommand(QCommand);
                    break;
                case Keys.W:
                    SendCommand(WCommand);
                    break;
                case Keys.E:
                    SendCommand(ECommand);
                    break;
                case Keys.A:
                    SendCommand(ACommand);
                    break;
                case Keys.S:
                    SendCommand(SCommand);
                    break;
                case Keys.D:
                    SendCommand(DCommand);
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            switch(e.KeyCode)
            {
                case Keys.Q:
                case Keys.W:
                case Keys.E:
                case Keys.A:
                case Keys.S:
                case Keys.D:
                    SendCommand(STOPCommand);
                    break; 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPortNameCB.DataSource = SerialPort.GetPortNames();
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            MessageBox.Show("Произошла ошибка. Соединение прервано");
            Disconnect();

        }
    }
}
