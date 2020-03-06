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
            this.W = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WCommand = new System.Windows.Forms.TextBox();
            this.ACommand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SCommand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DCommand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ECommand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.QCommand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.STOPCommand = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.serialPortNameCB = new System.Windows.Forms.ComboBox();
            this.updateComBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // W
            // 
            this.W.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.W.Enabled = false;
            this.W.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.W.Location = new System.Drawing.Point(68, 12);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(130, 50);
            this.W.TabIndex = 0;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            this.W.MouseDown += new System.Windows.Forms.MouseEventHandler(this.W_MouseDown);
            this.W.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlMouseUp);
            // 
            // S
            // 
            this.S.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.S.Enabled = false;
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.Location = new System.Drawing.Point(68, 68);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(130, 50);
            this.S.TabIndex = 1;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.MouseDown += new System.Windows.Forms.MouseEventHandler(this.S_MouseDown);
            this.S.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlMouseUp);
            // 
            // D
            // 
            this.D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.D.Enabled = false;
            this.D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D.Location = new System.Drawing.Point(202, 68);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(50, 50);
            this.D.TabIndex = 2;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.MouseDown += new System.Windows.Forms.MouseEventHandler(this.D_MouseDown);
            this.D.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlMouseUp);
            // 
            // A
            // 
            this.A.Enabled = false;
            this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A.Location = new System.Drawing.Point(12, 68);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(50, 50);
            this.A.TabIndex = 3;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.A_MouseDown);
            this.A.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlMouseUp);
            // 
            // Q
            // 
            this.Q.Enabled = false;
            this.Q.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Q.Location = new System.Drawing.Point(12, 12);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(50, 50);
            this.Q.TabIndex = 4;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            this.Q.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Q_MouseDown);
            this.Q.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlMouseUp);
            // 
            // E
            // 
            this.E.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.E.Enabled = false;
            this.E.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.E.Location = new System.Drawing.Point(202, 12);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(50, 50);
            this.E.TabIndex = 5;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.MouseDown += new System.Windows.Forms.MouseEventHandler(this.E_MouseDown);
            this.E.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlMouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Команды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "W";
            // 
            // WCommand
            // 
            this.WCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WCommand.Location = new System.Drawing.Point(36, 144);
            this.WCommand.Name = "WCommand";
            this.WCommand.Size = new System.Drawing.Size(216, 20);
            this.WCommand.TabIndex = 8;
            this.WCommand.Text = "U";
            // 
            // ACommand
            // 
            this.ACommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ACommand.Location = new System.Drawing.Point(36, 170);
            this.ACommand.Name = "ACommand";
            this.ACommand.Size = new System.Drawing.Size(216, 20);
            this.ACommand.TabIndex = 10;
            this.ACommand.Text = "L";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A";
            // 
            // SCommand
            // 
            this.SCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCommand.Location = new System.Drawing.Point(36, 196);
            this.SCommand.Name = "SCommand";
            this.SCommand.Size = new System.Drawing.Size(216, 20);
            this.SCommand.TabIndex = 12;
            this.SCommand.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "S";
            // 
            // DCommand
            // 
            this.DCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DCommand.Location = new System.Drawing.Point(36, 222);
            this.DCommand.Name = "DCommand";
            this.DCommand.Size = new System.Drawing.Size(216, 20);
            this.DCommand.TabIndex = 14;
            this.DCommand.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "D";
            // 
            // ECommand
            // 
            this.ECommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ECommand.Location = new System.Drawing.Point(36, 248);
            this.ECommand.Name = "ECommand";
            this.ECommand.Size = new System.Drawing.Size(216, 20);
            this.ECommand.TabIndex = 16;
            this.ECommand.Text = "F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "E";
            // 
            // QCommand
            // 
            this.QCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QCommand.Location = new System.Drawing.Point(36, 274);
            this.QCommand.Name = "QCommand";
            this.QCommand.Size = new System.Drawing.Size(216, 20);
            this.QCommand.TabIndex = 18;
            this.QCommand.Text = "E";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Q";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConnectButton.Location = new System.Drawing.Point(0, 358);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(264, 23);
            this.ConnectButton.TabIndex = 27;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // STOPCommand
            // 
            this.STOPCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.STOPCommand.Location = new System.Drawing.Point(51, 300);
            this.STOPCommand.Name = "STOPCommand";
            this.STOPCommand.Size = new System.Drawing.Size(201, 20);
            this.STOPCommand.TabIndex = 29;
            this.STOPCommand.Text = "s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "STOP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "COM-порт";
            // 
            // serialPortNameCB
            // 
            this.serialPortNameCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortNameCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortNameCB.FormattingEnabled = true;
            this.serialPortNameCB.Location = new System.Drawing.Point(68, 325);
            this.serialPortNameCB.Name = "serialPortNameCB";
            this.serialPortNameCB.Size = new System.Drawing.Size(103, 21);
            this.serialPortNameCB.TabIndex = 31;
            // 
            // updateComBT
            // 
            this.updateComBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateComBT.Location = new System.Drawing.Point(177, 323);
            this.updateComBT.Name = "updateComBT";
            this.updateComBT.Size = new System.Drawing.Size(75, 23);
            this.updateComBT.TabIndex = 32;
            this.updateComBT.Text = "Обновить";
            this.updateComBT.UseVisualStyleBackColor = true;
            this.updateComBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 381);
            this.Controls.Add(this.updateComBT);
            this.Controls.Add(this.serialPortNameCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.STOPCommand);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.QCommand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ECommand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DCommand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SCommand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ACommand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.E);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.A);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.W);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(200, 420);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "ы";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button W;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button Q;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WCommand;
        private System.Windows.Forms.TextBox ACommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ECommand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox QCommand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox STOPCommand;
        private System.Windows.Forms.Label label9;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox serialPortNameCB;
        private System.Windows.Forms.Button updateComBT;
    }
}

