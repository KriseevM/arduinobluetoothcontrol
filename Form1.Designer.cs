namespace ARDUINOBTCONTROL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.serialPortNameCB = new System.Windows.Forms.ComboBox();
            this.updateComBT = new System.Windows.Forms.Button();
            this.joystick = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConnectButton.Location = new System.Drawing.Point(0, 248);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(183, 23);
            this.ConnectButton.TabIndex = 27;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "COM-порт";
            // 
            // serialPortNameCB
            // 
            this.serialPortNameCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortNameCB.FormattingEnabled = true;
            this.serialPortNameCB.Location = new System.Drawing.Point(68, 186);
            this.serialPortNameCB.Name = "serialPortNameCB";
            this.serialPortNameCB.Size = new System.Drawing.Size(49, 21);
            this.serialPortNameCB.TabIndex = 31;
            // 
            // updateComBT
            // 
            this.updateComBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updateComBT.Location = new System.Drawing.Point(5, 213);
            this.updateComBT.Name = "updateComBT";
            this.updateComBT.Size = new System.Drawing.Size(112, 23);
            this.updateComBT.TabIndex = 32;
            this.updateComBT.Text = "Обновить";
            this.updateComBT.UseVisualStyleBackColor = true;
            this.updateComBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // joystick
            // 
            this.joystick.BackColor = System.Drawing.Color.Gray;
            this.joystick.Location = new System.Drawing.Point(12, 12);
            this.joystick.Name = "joystick";
            this.joystick.Size = new System.Drawing.Size(161, 161);
            this.joystick.TabIndex = 33;
            this.joystick.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.joystick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.joystick_MouseMove);
            this.joystick.MouseUp += new System.Windows.Forms.MouseEventHandler(this.joystick_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 271);
            this.Controls.Add(this.joystick);
            this.Controls.Add(this.updateComBT);
            this.Controls.Add(this.serialPortNameCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ConnectButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(200, 250);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Arduino Bluetooth control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox serialPortNameCB;
        private System.Windows.Forms.Button updateComBT;
        private System.Windows.Forms.Panel joystick;
    }
}

