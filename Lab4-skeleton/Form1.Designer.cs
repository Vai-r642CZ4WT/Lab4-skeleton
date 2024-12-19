namespace Lab4_skeleton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            saveUDPDataBtn = new Button();
            inText = new TextBox();
            label2 = new Label();
            outText = new TextBox();
            sendUDPDataBtn = new Button();
            ip = new TextBox();
            label3 = new Label();
            port = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            localPortLable = new Label();
            portLocal = new TextBox();
            history = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Кодировка";
            // 
            // saveUDPDataBtn
            // 
            saveUDPDataBtn.Location = new Point(320, 187);
            saveUDPDataBtn.Name = "saveUDPDataBtn";
            saveUDPDataBtn.Size = new Size(137, 23);
            saveUDPDataBtn.TabIndex = 1;
            saveUDPDataBtn.Text = "Подключиться";
            saveUDPDataBtn.UseVisualStyleBackColor = true;
            saveUDPDataBtn.Click += saveUDPDataBtn_Click;
            // 
            // inText
            // 
            inText.Location = new Point(9, 27);
            inText.Multiline = true;
            inText.Name = "inText";
            inText.Size = new Size(296, 172);
            inText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "История вывода";
            // 
            // outText
            // 
            outText.Location = new Point(492, 27);
            outText.Multiline = true;
            outText.Name = "outText";
            outText.Size = new Size(296, 384);
            outText.TabIndex = 5;
            // 
            // sendUDPDataBtn
            // 
            sendUDPDataBtn.Location = new Point(320, 216);
            sendUDPDataBtn.Name = "sendUDPDataBtn";
            sendUDPDataBtn.Size = new Size(137, 23);
            sendUDPDataBtn.TabIndex = 6;
            sendUDPDataBtn.Text = "Отправить";
            sendUDPDataBtn.UseVisualStyleBackColor = true;
            sendUDPDataBtn.Click += sendUDPDataBtn_Click;
            // 
            // ip
            // 
            ip.Location = new Point(320, 157);
            ip.Multiline = true;
            ip.Name = "ip";
            ip.Size = new Size(137, 24);
            ip.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 137);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "ip адрес";
            // 
            // port
            // 
            port.Location = new Point(320, 110);
            port.Multiline = true;
            port.Name = "port";
            port.Size = new Size(137, 24);
            port.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 92);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 10;
            label4.Text = "Удаленный порт";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(320, 25);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "На этом компьютере";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // localPortLable
            // 
            localPortLable.AutoSize = true;
            localPortLable.Location = new Point(320, 47);
            localPortLable.Name = "localPortLable";
            localPortLable.Size = new Size(99, 15);
            localPortLable.TabIndex = 13;
            localPortLable.Text = "Локальный порт";
            // 
            // portLocal
            // 
            portLocal.Location = new Point(320, 65);
            portLocal.Multiline = true;
            portLocal.Name = "portLocal";
            portLocal.Size = new Size(137, 24);
            portLocal.TabIndex = 12;
            // 
            // history
            // 
            history.FormattingEnabled = true;
            history.ItemHeight = 15;
            history.Location = new Point(12, 240);
            history.Name = "history";
            history.Size = new Size(293, 184);
            history.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(history);
            Controls.Add(localPortLable);
            Controls.Add(portLocal);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(port);
            Controls.Add(label3);
            Controls.Add(ip);
            Controls.Add(sendUDPDataBtn);
            Controls.Add(outText);
            Controls.Add(label2);
            Controls.Add(inText);
            Controls.Add(saveUDPDataBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button saveUDPDataBtn;
        private TextBox inText;
        private Label label2;
        private TextBox outText;
        private Button sendUDPDataBtn;
        private TextBox ip;
        private Label label3;
        private TextBox port;
        private Label label4;
        private CheckBox checkBox1;
        private Label localPortLable;
        private TextBox portLocal;
        private ListBox history;
    }
}
