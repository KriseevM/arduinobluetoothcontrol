using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            serialPort1.PortName = "COM" + portNumber.Value.ToString();
            serialPort1.Open();
        }
        void SendCommand(TextBox commandTextBox)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(commandTextBox.Text);
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
            switch(e.KeyCode)
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

        
    }
}
