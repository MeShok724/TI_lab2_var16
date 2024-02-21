using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class FormFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.lKey2 = new System.Windows.Forms.Label();
            this.tbKey1 = new System.Windows.Forms.TextBox();
            this.lKey1 = new System.Windows.Forms.Label();
            this.cbMethodEnc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(900, 669);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 65);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 669);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 65);
            this.button2.TabIndex = 19;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 669);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 65);
            this.button1.TabIndex = 18;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbKey2
            // 
            this.tbKey2.Location = new System.Drawing.Point(724, 520);
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(304, 40);
            this.tbKey2.TabIndex = 17;
            // 
            // lKey2
            // 
            this.lKey2.Location = new System.Drawing.Point(714, 465);
            this.lKey2.Name = "lKey2";
            this.lKey2.Size = new System.Drawing.Size(314, 33);
            this.lKey2.TabIndex = 16;
            this.lKey2.Text = "Введите второй ключ:";
            // 
            // tbKey1
            // 
            this.tbKey1.Location = new System.Drawing.Point(724, 395);
            this.tbKey1.Name = "tbKey1";
            this.tbKey1.Size = new System.Drawing.Size(304, 40);
            this.tbKey1.TabIndex = 15;
            // 
            // lKey1
            // 
            this.lKey1.Location = new System.Drawing.Point(714, 340);
            this.lKey1.Name = "lKey1";
            this.lKey1.Size = new System.Drawing.Size(314, 33);
            this.lKey1.TabIndex = 14;
            this.lKey1.Text = "Введите первый ключ:";
            // 
            // cbMethodEnc
            // 
            this.cbMethodEnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethodEnc.FormattingEnabled = true;
            this.cbMethodEnc.Items.AddRange(new object[] { "Столбцовый метод", "Метод Виженера" });
            this.cbMethodEnc.Location = new System.Drawing.Point(154, 407);
            this.cbMethodEnc.Margin = new System.Windows.Forms.Padding(5);
            this.cbMethodEnc.Name = "cbMethodEnc";
            this.cbMethodEnc.Size = new System.Drawing.Size(440, 40);
            this.cbMethodEnc.TabIndex = 13;
            this.cbMethodEnc.Tag = "";
            this.cbMethodEnc.SelectedIndexChanged += new System.EventHandler(this.cbMethodEnc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(154, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите метод шифрования";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Выбранный файл:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(157, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 33);
            this.label3.TabIndex = 22;
            this.label3.Text = "Результат:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(403, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(404, 40);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(403, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(404, 40);
            this.textBox2.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 52);
            this.button3.TabIndex = 25;
            this.button3.Text = "выбрать файл";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(878, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 52);
            this.button4.TabIndex = 26;
            this.button4.Text = "выбрать файл";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKey2);
            this.Controls.Add(this.lKey2);
            this.Controls.Add(this.tbKey1);
            this.Controls.Add(this.lKey1);
            this.Controls.Add(this.cbMethodEnc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шпионский Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbKey2;
        private System.Windows.Forms.Label lKey2;
        private System.Windows.Forms.TextBox tbKey1;
        private System.Windows.Forms.Label lKey1;
        private System.Windows.Forms.ComboBox cbMethodEnc;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}