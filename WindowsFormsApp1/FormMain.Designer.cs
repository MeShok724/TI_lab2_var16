using System.ComponentModel;

namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMethodEnc = new System.Windows.Forms.ComboBox();
            this.lKey1 = new System.Windows.Forms.Label();
            this.tbKey1 = new System.Windows.Forms.TextBox();
            this.tbKey2 = new System.Windows.Forms.TextBox();
            this.lKey2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите метод шифрования";
            // 
            // cbMethodEnc
            // 
            this.cbMethodEnc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethodEnc.FormattingEnabled = true;
            this.cbMethodEnc.Items.AddRange(new object[] { "Столбцовый метод", "Метод Виженера" });
            this.cbMethodEnc.Location = new System.Drawing.Point(79, 125);
            this.cbMethodEnc.Margin = new System.Windows.Forms.Padding(5);
            this.cbMethodEnc.Name = "cbMethodEnc";
            this.cbMethodEnc.Size = new System.Drawing.Size(440, 40);
            this.cbMethodEnc.TabIndex = 1;
            this.cbMethodEnc.Tag = "";
            this.cbMethodEnc.SelectedIndexChanged += new System.EventHandler(this.cbMethodEnc_SelectedIndexChanged);
            // 
            // lKey1
            // 
            this.lKey1.Location = new System.Drawing.Point(639, 58);
            this.lKey1.Name = "lKey1";
            this.lKey1.Size = new System.Drawing.Size(314, 33);
            this.lKey1.TabIndex = 2;
            this.lKey1.Text = "Введите первый ключ:";
            // 
            // tbKey1
            // 
            this.tbKey1.Location = new System.Drawing.Point(649, 113);
            this.tbKey1.Name = "tbKey1";
            this.tbKey1.Size = new System.Drawing.Size(304, 40);
            this.tbKey1.TabIndex = 3;
            // 
            // tbKey2
            // 
            this.tbKey2.Location = new System.Drawing.Point(1065, 113);
            this.tbKey2.Name = "tbKey2";
            this.tbKey2.Size = new System.Drawing.Size(304, 40);
            this.tbKey2.TabIndex = 5;
            // 
            // lKey2
            // 
            this.lKey2.Location = new System.Drawing.Point(1055, 58);
            this.lKey2.Name = "lKey2";
            this.lKey2.Size = new System.Drawing.Size(314, 33);
            this.lKey2.TabIndex = 4;
            this.lKey2.Text = "Введите второй ключ:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(79, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(990, 45);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите текст для шифрования/дешифрования или прочитайте из файла:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(80, 421);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(703, 218);
            this.tbInput.TabIndex = 8;
            this.tbInput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 708);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 708);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 65);
            this.button2.TabIndex = 10;
            this.button2.Text = "Дешифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(884, 421);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(703, 218);
            this.tbResult.TabIndex = 13;
            this.tbResult.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(884, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Полученный шифр:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(387, 65);
            this.button3.TabIndex = 14;
            this.button3.Text = "Выбрать файл...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(884, 708);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(361, 65);
            this.button4.TabIndex = 15;
            this.button4.Text = "Сохранить в файл...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1339, 708);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 65);
            this.button5.TabIndex = 16;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 944);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKey2);
            this.Controls.Add(this.lKey2);
            this.Controls.Add(this.tbKey1);
            this.Controls.Add(this.lKey1);
            this.Controls.Add(this.cbMethodEnc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифратор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button5;

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.RichTextBox tbInput;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox tbKey1;
        private System.Windows.Forms.Label lKey2;

        private System.Windows.Forms.TextBox tbKey2;

        private System.Windows.Forms.Label lKey1;

        private System.Windows.Forms.ComboBox cbMethodEnc;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}