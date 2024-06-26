﻿using System.ComponentModel;

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
            this.tbRegister = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.btnEncript = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.RichTextBox();
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
            // tbRegister
            // 
            this.tbRegister.Location = new System.Drawing.Point(397, 58);
            this.tbRegister.Name = "tbRegister";
            this.tbRegister.Size = new System.Drawing.Size(703, 40);
            this.tbRegister.TabIndex = 3;
            this.tbRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegister_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(79, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(990, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Выберите файл для шифровани/дешифрования:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(79, 476);
            this.tbInput.Name = "tbInput";
            this.tbInput.ReadOnly = true;
            this.tbInput.Size = new System.Drawing.Size(703, 259);
            this.tbInput.TabIndex = 8;
            this.tbInput.Text = "";
            // 
            // btnEncript
            // 
            this.btnEncript.Location = new System.Drawing.Point(105, 788);
            this.btnEncript.Name = "btnEncript";
            this.btnEncript.Size = new System.Drawing.Size(440, 65);
            this.btnEncript.TabIndex = 9;
            this.btnEncript.Text = "Зашифровать/Дешифровать";
            this.btnEncript.UseVisualStyleBackColor = true;
            this.btnEncript.Click += new System.EventHandler(this.btnEncript_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(883, 476);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(703, 259);
            this.tbResult.TabIndex = 13;
            this.tbResult.Text = "";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(883, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Результат:";
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Location = new System.Drawing.Point(80, 386);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(387, 65);
            this.btnChoseFile.TabIndex = 14;
            this.btnChoseFile.Text = "Выбрать файл...";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(883, 788);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(361, 65);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Сохранить в файл...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1338, 788);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(248, 65);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(80, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Полученный ключ:";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(397, 146);
            this.tbKey.Name = "tbKey";
            this.tbKey.ReadOnly = true;
            this.tbKey.Size = new System.Drawing.Size(703, 156);
            this.tbKey.TabIndex = 13;
            this.tbKey.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 944);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEncript);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lKey1);
            this.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbRegister;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btnEncript;

        private System.Windows.Forms.RichTextBox tbInput;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.RichTextBox tbKey;

        private System.Windows.Forms.Label lKey1;

        #endregion
    }
}