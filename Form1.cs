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
        bool mouseDown = false;
        Graphics joystickgraphics;
        public Form1()
        {
            InitializeComponent();
            serialPortNameCB.DataSource = SerialPort.GetPortNames();
            joystickgraphics = joystick.CreateGraphics();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Соединение прервано из-за ошибки. " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                updateComBT.Enabled = true;
                serialPortNameCB.Enabled = true;
                ConnectButton.Text = "Подключиться";
            }
        }

        private void Disconnect()
        {
            serialPort1.Close();
            joystick.Enabled = false;
            updateComBT.Enabled = true;
            serialPortNameCB.Enabled = true;
            joystickgraphics.Clear(Color.Gray);
            ConnectButton.Text = "Подключиться";
        }

        private void Connect()
        {
            serialPort1.PortName = serialPortNameCB.SelectedItem.ToString();
            serialPort1.Open();
            joystickgraphics.DrawEllipse(Pens.Red, 0, 0, 160, 160);
            joystickgraphics.FillEllipse(Brushes.Blue, 55, 55, 50, 50);
            joystick.Enabled = true;
            updateComBT.Enabled = false;
            serialPortNameCB.Enabled = false;
            ConnectButton.Text = "Отключиться";
        }

        void SendCommand(string command)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(command);
                }
                else
                {
                    MessageBox.Show("Не удалось подключиться к последовательному порту. Убедитесь, что порт еще доступен, обновите список и выберите порт в списке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                Disconnect();
                MessageBox.Show("Соединение прервано из-за ошибки. " + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void joystick_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            joystickgraphics.Clear(Color.Gray);
            joystickgraphics.DrawEllipse(Pens.Red, 0, 0, 160, 160);
            joystickgraphics.FillEllipse(Brushes.Blue, 55, 55, 50, 50);
            SendCommand("s");
        }

        private void joystick_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown) return;
            joystickgraphics.Clear(Color.Gray);
            joystickgraphics.DrawEllipse(Pens.Red, 0, 0, 160, 160);
            int x = e.X;
            int y = e.Y;
            int offsetX = x - 80;
            int offsetY = y - 80;
            if (offsetX * offsetX + offsetY * offsetY <= 3025)
            {
                joystickgraphics.FillEllipse(Brushes.Blue, x - 25, y - 25, 50, 50);
            }
            else
            {
                
                if (offsetY != 0)
                {
                    double div = ((double)offsetX) / ((double)offsetY);
                    double boundY = (offsetY > 0 ? 1 : -1) * Math.Sqrt(3025 / (div * div + 1));
                    
                    double boundX = div * boundY;
                    
                    joystickgraphics.FillEllipse(Brushes.Blue, 55 + (int)boundX, 55 + (int)boundY, 50, 50);
                }
                else
                {
                    
                    if(offsetX > 0)
                    joystickgraphics.FillEllipse(Brushes.Blue, 110, 55, 50, 50);
                    else
                    {
                        joystickgraphics.FillEllipse(Brushes.Blue, 0, 55, 50, 50);
                    }
                }
            }
            if (offsetY != 0)
            {
                double div = ((double)offsetX) / ((double)offsetY);
                double sin = (offsetY > 0 ? -1 : 1) * Math.Sqrt(1 / (div * div + 1));

                double cos = (offsetY > 0 ? 1 : -1)*div * sin;
                double asin = Math.Asin(sin);
                double acos = Math.Acos(cos);
                double angle;
                if(sin > 0)
                {
                    angle = ((180 / Math.PI) * acos);
                }
                else
                {
                    angle = 180 + ((180 / Math.PI) * (acos));
                }
                if(angle < 90)
                {
                    angle = 90 - angle;
                }
                else angle = 450 - angle;
                int M = (int)(Math.Sqrt(offsetX * offsetX + offsetY * offsetY) / 55 * 255);
                SendCommand($"M{((M > 255) ? 255 : M)}A{(int) angle}");
            }
            else
            {
                if(offsetX == 0)
                {
                    SendCommand("s");
                }
                else if(offsetX > 0)
                {
                    
                    SendCommand($"M{offsetX}A90");
                }
                else
                {
                    
                    SendCommand($"M{-offsetX}A270");
                }
                
            }
        }
    }
}
