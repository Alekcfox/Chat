using System.Drawing;

namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.ChatWindow = new System.Windows.Forms.RichTextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.TestBoxL = new System.Windows.Forms.RichTextBox();
            this.TestBoxS = new System.Windows.Forms.RichTextBox();
            this.Privat = new System.Windows.Forms.GroupBox();
            this.ButtonChat5 = new System.Windows.Forms.Button();
            this.ButtonChat4 = new System.Windows.Forms.Button();
            this.ButtonChat3 = new System.Windows.Forms.Button();
            this.ButtonChat2 = new System.Windows.Forms.Button();
            this.ButtonChat1 = new System.Windows.Forms.Button();
            this.ButtonChat0 = new System.Windows.Forms.Button();
            this.Name2Box = new System.Windows.Forms.TextBox();
            this.CreatePrivatChatButton = new System.Windows.Forms.Button();
            this.DeletehisChatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.Privat.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.PowderBlue;
            this.NameBox.ForeColor = System.Drawing.Color.Red;
            this.NameBox.Location = new System.Drawing.Point(66, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(218, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Введите своё имя";
            this.NameBox.Enter += new System.EventHandler(this.NameBox_Enter);
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // ChatWindow
            // 
            this.ChatWindow.BackColor = System.Drawing.Color.PowderBlue;
            this.ChatWindow.Location = new System.Drawing.Point(12, 54);
            this.ChatWindow.Name = "ChatWindow";
            this.ChatWindow.Size = new System.Drawing.Size(347, 196);
            this.ChatWindow.TabIndex = 1;
            this.ChatWindow.Text = "Чат";
            this.ChatWindow.TextChanged += new System.EventHandler(this.ChatWindow_TextChanged);
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.PowderBlue;
            this.InputBox.ForeColor = System.Drawing.Color.Gray;
            this.InputBox.Location = new System.Drawing.Point(12, 265);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(584, 20);
            this.InputBox.TabIndex = 2;
            this.InputBox.Text = "Введите ваше сообщение";
            this.InputBox.Enter += new System.EventHandler(this.InputBox_Enter);
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            // 
            // TestBoxL
            // 
            this.TestBoxL.Location = new System.Drawing.Point(638, 33);
            this.TestBoxL.Name = "TestBoxL";
            this.TestBoxL.Size = new System.Drawing.Size(159, 172);
            this.TestBoxL.TabIndex = 4;
            this.TestBoxL.Text = "Test1";
            // 
            // TestBoxS
            // 
            this.TestBoxS.Location = new System.Drawing.Point(638, 235);
            this.TestBoxS.Name = "TestBoxS";
            this.TestBoxS.Size = new System.Drawing.Size(171, 85);
            this.TestBoxS.TabIndex = 5;
            this.TestBoxS.Text = "Test2";
            // 
            // Privat
            // 
            this.Privat.Controls.Add(this.ButtonChat5);
            this.Privat.Controls.Add(this.ButtonChat4);
            this.Privat.Controls.Add(this.ButtonChat3);
            this.Privat.Controls.Add(this.ButtonChat2);
            this.Privat.Controls.Add(this.ButtonChat1);
            this.Privat.Controls.Add(this.ButtonChat0);
            this.Privat.Location = new System.Drawing.Point(365, 54);
            this.Privat.Name = "Privat";
            this.Privat.Size = new System.Drawing.Size(231, 196);
            this.Privat.TabIndex = 6;
            this.Privat.TabStop = false;
            this.Privat.Text = "Privat";
            // 
            // ButtonChat5
            // 
            this.ButtonChat5.Location = new System.Drawing.Point(6, 164);
            this.ButtonChat5.Name = "ButtonChat5";
            this.ButtonChat5.Size = new System.Drawing.Size(215, 23);
            this.ButtonChat5.TabIndex = 12;
            this.ButtonChat5.UseVisualStyleBackColor = true;
            this.ButtonChat5.Click += new System.EventHandler(this.ButtonChat5_Click);
            // 
            // ButtonChat4
            // 
            this.ButtonChat4.Location = new System.Drawing.Point(6, 135);
            this.ButtonChat4.Name = "ButtonChat4";
            this.ButtonChat4.Size = new System.Drawing.Size(215, 23);
            this.ButtonChat4.TabIndex = 11;
            this.ButtonChat4.UseVisualStyleBackColor = true;
            this.ButtonChat4.Click += new System.EventHandler(this.ButtonChat4_Click);
            // 
            // ButtonChat3
            // 
            this.ButtonChat3.Location = new System.Drawing.Point(6, 106);
            this.ButtonChat3.Name = "ButtonChat3";
            this.ButtonChat3.Size = new System.Drawing.Size(215, 23);
            this.ButtonChat3.TabIndex = 10;
            this.ButtonChat3.UseVisualStyleBackColor = true;
            this.ButtonChat3.Click += new System.EventHandler(this.ButtonChat3_Click);
            // 
            // ButtonChat2
            // 
            this.ButtonChat2.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonChat2.Location = new System.Drawing.Point(6, 77);
            this.ButtonChat2.Name = "ButtonChat2";
            this.ButtonChat2.Size = new System.Drawing.Size(215, 23);
            this.ButtonChat2.TabIndex = 9;
            this.ButtonChat2.UseVisualStyleBackColor = false;
            this.ButtonChat2.Click += new System.EventHandler(this.ButtonChat2_Click);
            // 
            // ButtonChat1
            // 
            this.ButtonChat1.Location = new System.Drawing.Point(6, 48);
            this.ButtonChat1.Name = "ButtonChat1";
            this.ButtonChat1.Size = new System.Drawing.Size(215, 23);
            this.ButtonChat1.TabIndex = 8;
            this.ButtonChat1.UseVisualStyleBackColor = true;
            this.ButtonChat1.Click += new System.EventHandler(this.ButtonChat1_Click);
            // 
            // ButtonChat0
            // 
            this.ButtonChat0.Location = new System.Drawing.Point(6, 19);
            this.ButtonChat0.Name = "ButtonChat0";
            this.ButtonChat0.Size = new System.Drawing.Size(215, 23);
            this.ButtonChat0.TabIndex = 7;
            this.ButtonChat0.UseVisualStyleBackColor = true;
            this.ButtonChat0.Click += new System.EventHandler(this.ButtonChat0_Click);
            // 
            // Name2Box
            // 
            this.Name2Box.BackColor = System.Drawing.Color.PowderBlue;
            this.Name2Box.Location = new System.Drawing.Point(445, 9);
            this.Name2Box.Name = "Name2Box";
            this.Name2Box.Size = new System.Drawing.Size(151, 20);
            this.Name2Box.TabIndex = 7;
            // 
            // CreatePrivatChatButton
            // 
            this.CreatePrivatChatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CreatePrivatChatButton.Location = new System.Drawing.Point(365, 9);
            this.CreatePrivatChatButton.Name = "CreatePrivatChatButton";
            this.CreatePrivatChatButton.Size = new System.Drawing.Size(74, 23);
            this.CreatePrivatChatButton.TabIndex = 8;
            this.CreatePrivatChatButton.Text = "Connect to:";
            this.CreatePrivatChatButton.UseVisualStyleBackColor = false;
            this.CreatePrivatChatButton.Click += new System.EventHandler(this.CreatePrivatChatButton_Click);
            // 
            // DeletehisChatButton
            // 
            this.DeletehisChatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeletehisChatButton.Location = new System.Drawing.Point(504, 35);
            this.DeletehisChatButton.Name = "DeletehisChatButton";
            this.DeletehisChatButton.Size = new System.Drawing.Size(92, 23);
            this.DeletehisChatButton.TabIndex = 9;
            this.DeletehisChatButton.Text = "Delete this chat";
            this.DeletehisChatButton.UseVisualStyleBackColor = false;
            this.DeletehisChatButton.Click += new System.EventHandler(this.DeletehisChatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.Color.Plum;
            this.ButtonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ButtonSend.ForeColor = System.Drawing.Color.Aqua;
            this.ButtonSend.Location = new System.Drawing.Point(12, 291);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(130, 31);
            this.ButtonSend.TabIndex = 3;
            this.ButtonSend.Text = "Send to flight";
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(611, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletehisChatButton);
            this.Controls.Add(this.CreatePrivatChatButton);
            this.Controls.Add(this.Name2Box);
            this.Controls.Add(this.Privat);
            this.Controls.Add(this.TestBoxS);
            this.Controls.Add(this.TestBoxL);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.ChatWindow);
            this.Controls.Add(this.NameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Swallow Chat";
            this.Privat.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.RichTextBox ChatWindow;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ButtonSend;
        public System.Windows.Forms.RichTextBox TestBoxL;
        private System.Windows.Forms.RichTextBox TestBoxS;
        private System.Windows.Forms.GroupBox Privat;
        private System.Windows.Forms.Button ButtonChat0;
        private System.Windows.Forms.Button ButtonChat5;
        private System.Windows.Forms.Button ButtonChat4;
        private System.Windows.Forms.Button ButtonChat3;
        private System.Windows.Forms.Button ButtonChat2;
        private System.Windows.Forms.Button ButtonChat1;
        private System.Windows.Forms.TextBox Name2Box;
        private System.Windows.Forms.Button CreatePrivatChatButton;
        private System.Windows.Forms.Button DeletehisChatButton;
        private System.Windows.Forms.Label label1;
    }
}

