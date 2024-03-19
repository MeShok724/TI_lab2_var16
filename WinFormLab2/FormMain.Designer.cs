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
            this.lKey1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.btnEncript = new System.Windows.Forms.Button();
            this.btnDecript = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lKey1
            // 
            this.lKey1.Location = new System.Drawing.Point(79, 58);
            this.lKey1.Name = "lKey1";
            this.lKey1.Size = new System.Drawing.Size(205, 33);
            this.lKey1.TabIndex = 2;
            this.lKey1.Text = "Введите ключ:";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(79, 136);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(304, 40);
            this.tbKey.TabIndex = 3;
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
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(703, 218);
            this.tbInput.TabIndex = 8;
            this.tbInput.Text = "";
            // 
            // btnEncript
            // 
            this.btnEncript.Location = new System.Drawing.Point(106, 708);
            this.btnEncript.Name = "btnEncript";
            this.btnEncript.Size = new System.Drawing.Size(270, 65);
            this.btnEncript.TabIndex = 9;
            this.btnEncript.Text = "Зашифровать";
            this.btnEncript.UseVisualStyleBackColor = true;
            this.btnEncript.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // btnDecript
            // 
            this.btnDecript.Location = new System.Drawing.Point(483, 708);
            this.btnDecript.Name = "btnDecript";
            this.btnDecript.Size = new System.Drawing.Size(270, 65);
            this.btnDecript.TabIndex = 10;
            this.btnDecript.Text = "Дешифровать";
            this.btnDecript.UseVisualStyleBackColor = true;
            this.btnDecript.Click += new System.EventHandler(this.btnDecript_Click);
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
            // btnChoseFile
            // 
            this.btnChoseFile.Location = new System.Drawing.Point(80, 315);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(387, 65);
            this.btnChoseFile.TabIndex = 14;
            this.btnChoseFile.Text = "Выбрать файл...";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(884, 708);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(361, 65);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить в файл...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1339, 708);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(248, 65);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 944);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecript);
            this.Controls.Add(this.btnEncript);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lKey1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnEncript;
        private System.Windows.Forms.Button btnDecript;

        private System.Windows.Forms.RichTextBox tbInput;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox tbKey;

        private System.Windows.Forms.Label lKey1;

        #endregion
    }
}