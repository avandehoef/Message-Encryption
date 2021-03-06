﻿namespace Versleutelen
{
    partial class versleutelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(versleutelForm));
            this.textBoxKeyOneInput = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxLoadEnterKey = new System.Windows.Forms.TextBox();
            this.textBoxKeyOneGen = new System.Windows.Forms.TextBox();
            this.textBoxLoadStartText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.textBoxLoadKeyGen = new System.Windows.Forms.TextBox();
            this.textBoxMasterKey = new System.Windows.Forms.TextBox();
            this.textBoxLoadMasterKey = new System.Windows.Forms.TextBox();
            this.textBoxMasterKeyInput = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExportInput = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPointers = new System.Windows.Forms.TextBox();
            this.btnExportOutput = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxExportOutput = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.textBoxKeyTwoInput = new System.Windows.Forms.TextBox();
            this.textBoxKeyTwoGen = new System.Windows.Forms.TextBox();
            this.textBoxLoadKeyTwoGen = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxKeyOneInput
            // 
            this.textBoxKeyOneInput.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxKeyOneInput.Location = new System.Drawing.Point(86, 124);
            this.textBoxKeyOneInput.MaxLength = 9;
            this.textBoxKeyOneInput.Name = "textBoxKeyOneInput";
            this.textBoxKeyOneInput.Size = new System.Drawing.Size(253, 34);
            this.textBoxKeyOneInput.TabIndex = 3;
            this.textBoxKeyOneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(86, 263);
            this.textBoxInput.MaxLength = 2500;
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(477, 300);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(86, 611);
            this.textBoxOutput.MaxLength = 2500;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(477, 300);
            this.textBoxOutput.TabIndex = 100;
            this.textBoxOutput.TabStop = false;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // textBoxLoadEnterKey
            // 
            this.textBoxLoadEnterKey.BackColor = System.Drawing.Color.Silver;
            this.textBoxLoadEnterKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoadEnterKey.Enabled = false;
            this.textBoxLoadEnterKey.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBoxLoadEnterKey.Location = new System.Drawing.Point(346, 133);
            this.textBoxLoadEnterKey.Name = "textBoxLoadEnterKey";
            this.textBoxLoadEnterKey.ReadOnly = true;
            this.textBoxLoadEnterKey.Size = new System.Drawing.Size(232, 20);
            this.textBoxLoadEnterKey.TabIndex = 3;
            this.textBoxLoadEnterKey.TabStop = false;
            this.textBoxLoadEnterKey.Text = "> Geef sleutel 1 op voor decryptie";
            // 
            // textBoxKeyOneGen
            // 
            this.textBoxKeyOneGen.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxKeyOneGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKeyOneGen.Enabled = false;
            this.textBoxKeyOneGen.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxKeyOneGen.Location = new System.Drawing.Point(622, 125);
            this.textBoxKeyOneGen.Name = "textBoxKeyOneGen";
            this.textBoxKeyOneGen.ReadOnly = true;
            this.textBoxKeyOneGen.Size = new System.Drawing.Size(188, 34);
            this.textBoxKeyOneGen.TabIndex = 4;
            this.textBoxKeyOneGen.TabStop = false;
            this.textBoxKeyOneGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoadStartText
            // 
            this.textBoxLoadStartText.BackColor = System.Drawing.Color.Silver;
            this.textBoxLoadStartText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoadStartText.Enabled = false;
            this.textBoxLoadStartText.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadStartText.Location = new System.Drawing.Point(86, 12);
            this.textBoxLoadStartText.Name = "textBoxLoadStartText";
            this.textBoxLoadStartText.ReadOnly = true;
            this.textBoxLoadStartText.Size = new System.Drawing.Size(832, 25);
            this.textBoxLoadStartText.TabIndex = 5;
            this.textBoxLoadStartText.TabStop = false;
            this.textBoxLoadStartText.Text = "Voer bericht in en versleutel of ontcijfer deze";
            this.textBoxLoadStartText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(622, 361);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(107, 42);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Versleutel";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(622, 421);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 42);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Ontcijfer";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // textBoxLoadKeyGen
            // 
            this.textBoxLoadKeyGen.BackColor = System.Drawing.Color.Silver;
            this.textBoxLoadKeyGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoadKeyGen.Enabled = false;
            this.textBoxLoadKeyGen.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBoxLoadKeyGen.Location = new System.Drawing.Point(816, 133);
            this.textBoxLoadKeyGen.Name = "textBoxLoadKeyGen";
            this.textBoxLoadKeyGen.ReadOnly = true;
            this.textBoxLoadKeyGen.Size = new System.Drawing.Size(171, 20);
            this.textBoxLoadKeyGen.TabIndex = 8;
            this.textBoxLoadKeyGen.TabStop = false;
            this.textBoxLoadKeyGen.Text = "> sleutel 1";
            // 
            // textBoxMasterKey
            // 
            this.textBoxMasterKey.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxMasterKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMasterKey.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxMasterKey.Location = new System.Drawing.Point(622, 75);
            this.textBoxMasterKey.Name = "textBoxMasterKey";
            this.textBoxMasterKey.ReadOnly = true;
            this.textBoxMasterKey.Size = new System.Drawing.Size(188, 34);
            this.textBoxMasterKey.TabIndex = 9;
            this.textBoxMasterKey.TabStop = false;
            this.textBoxMasterKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoadMasterKey
            // 
            this.textBoxLoadMasterKey.BackColor = System.Drawing.Color.Silver;
            this.textBoxLoadMasterKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoadMasterKey.Enabled = false;
            this.textBoxLoadMasterKey.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBoxLoadMasterKey.Location = new System.Drawing.Point(816, 83);
            this.textBoxLoadMasterKey.Name = "textBoxLoadMasterKey";
            this.textBoxLoadMasterKey.ReadOnly = true;
            this.textBoxLoadMasterKey.Size = new System.Drawing.Size(171, 20);
            this.textBoxLoadMasterKey.TabIndex = 10;
            this.textBoxLoadMasterKey.TabStop = false;
            this.textBoxLoadMasterKey.Text = "> masterkey";
            // 
            // textBoxMasterKeyInput
            // 
            this.textBoxMasterKeyInput.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxMasterKeyInput.Location = new System.Drawing.Point(86, 74);
            this.textBoxMasterKeyInput.MaxLength = 18;
            this.textBoxMasterKeyInput.Name = "textBoxMasterKeyInput";
            this.textBoxMasterKeyInput.Size = new System.Drawing.Size(253, 34);
            this.textBoxMasterKeyInput.TabIndex = 2;
            this.textBoxMasterKeyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBox2.Location = new System.Drawing.Point(345, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "> Geef masterkey op voor decryptie";
            // 
            // btnExportInput
            // 
            this.btnExportInput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportInput.Location = new System.Drawing.Point(622, 298);
            this.btnExportInput.Name = "btnExportInput";
            this.btnExportInput.Size = new System.Drawing.Size(107, 42);
            this.btnExportInput.TabIndex = 13;
            this.btnExportInput.Text = "Exporteer";
            this.btnExportInput.UseVisualStyleBackColor = true;
            this.btnExportInput.Click += new System.EventHandler(this.btnExportInput_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBox1.Location = new System.Drawing.Point(569, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TabStop = false;
            this.textBox1.Text = ">>>>>>";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPointers
            // 
            this.textBoxPointers.BackColor = System.Drawing.Color.Silver;
            this.textBoxPointers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPointers.Enabled = false;
            this.textBoxPointers.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxPointers.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBoxPointers.Location = new System.Drawing.Point(569, 661);
            this.textBoxPointers.Name = "textBoxPointers";
            this.textBoxPointers.ReadOnly = true;
            this.textBoxPointers.Size = new System.Drawing.Size(47, 20);
            this.textBoxPointers.TabIndex = 16;
            this.textBoxPointers.TabStop = false;
            this.textBoxPointers.Text = ">>>>>>";
            this.textBoxPointers.TextChanged += new System.EventHandler(this.textBoxPointers_TextChanged);
            // 
            // btnExportOutput
            // 
            this.btnExportOutput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportOutput.Location = new System.Drawing.Point(622, 649);
            this.btnExportOutput.Name = "btnExportOutput";
            this.btnExportOutput.Size = new System.Drawing.Size(107, 42);
            this.btnExportOutput.TabIndex = 15;
            this.btnExportOutput.Text = "Exporteer";
            this.btnExportOutput.UseVisualStyleBackColor = true;
            this.btnExportOutput.Click += new System.EventHandler(this.btnExportOutput_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Silver;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBox4.Location = new System.Drawing.Point(735, 310);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(171, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "> naar ExportVanInput.txt";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxExportOutput
            // 
            this.textBoxExportOutput.BackColor = System.Drawing.Color.Silver;
            this.textBoxExportOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExportOutput.Enabled = false;
            this.textBoxExportOutput.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBoxExportOutput.Location = new System.Drawing.Point(735, 661);
            this.textBoxExportOutput.Name = "textBoxExportOutput";
            this.textBoxExportOutput.ReadOnly = true;
            this.textBoxExportOutput.Size = new System.Drawing.Size(183, 20);
            this.textBoxExportOutput.TabIndex = 18;
            this.textBoxExportOutput.TabStop = false;
            this.textBoxExportOutput.Text = "> naar ExportVanOutput.txt";
            this.textBoxExportOutput.TextChanged += new System.EventHandler(this.textBoxExportOutput_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(880, 869);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 42);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // textBoxError
            // 
            this.textBoxError.BackColor = System.Drawing.Color.Silver;
            this.textBoxError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxError.Enabled = false;
            this.textBoxError.Font = new System.Drawing.Font("Calibri", 9F);
            this.textBoxError.Location = new System.Drawing.Point(86, 235);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.ReadOnly = true;
            this.textBoxError.Size = new System.Drawing.Size(477, 22);
            this.textBoxError.TabIndex = 20;
            this.textBoxError.TabStop = false;
            this.textBoxError.TextChanged += new System.EventHandler(this.textBoxError_TextChanged);
            // 
            // textBoxKeyTwoInput
            // 
            this.textBoxKeyTwoInput.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxKeyTwoInput.Location = new System.Drawing.Point(86, 178);
            this.textBoxKeyTwoInput.MaxLength = 9;
            this.textBoxKeyTwoInput.Name = "textBoxKeyTwoInput";
            this.textBoxKeyTwoInput.Size = new System.Drawing.Size(253, 34);
            this.textBoxKeyTwoInput.TabIndex = 4;
            this.textBoxKeyTwoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxKeyTwoGen
            // 
            this.textBoxKeyTwoGen.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxKeyTwoGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKeyTwoGen.Enabled = false;
            this.textBoxKeyTwoGen.Font = new System.Drawing.Font("Calibri", 11F);
            this.textBoxKeyTwoGen.Location = new System.Drawing.Point(622, 179);
            this.textBoxKeyTwoGen.Name = "textBoxKeyTwoGen";
            this.textBoxKeyTwoGen.ReadOnly = true;
            this.textBoxKeyTwoGen.Size = new System.Drawing.Size(188, 34);
            this.textBoxKeyTwoGen.TabIndex = 22;
            this.textBoxKeyTwoGen.TabStop = false;
            this.textBoxKeyTwoGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxLoadKeyTwoGen
            // 
            this.textBoxLoadKeyTwoGen.BackColor = System.Drawing.Color.Silver;
            this.textBoxLoadKeyTwoGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoadKeyTwoGen.Enabled = false;
            this.textBoxLoadKeyTwoGen.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBoxLoadKeyTwoGen.Location = new System.Drawing.Point(816, 187);
            this.textBoxLoadKeyTwoGen.Name = "textBoxLoadKeyTwoGen";
            this.textBoxLoadKeyTwoGen.ReadOnly = true;
            this.textBoxLoadKeyTwoGen.Size = new System.Drawing.Size(171, 20);
            this.textBoxLoadKeyTwoGen.TabIndex = 23;
            this.textBoxLoadKeyTwoGen.TabStop = false;
            this.textBoxLoadKeyTwoGen.Text = "> sleutel 2";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Silver;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 8F);
            this.textBox7.Location = new System.Drawing.Point(346, 187);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(232, 20);
            this.textBox7.TabIndex = 24;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "> Geef sleutel 2 op voor decryptie";
            // 
            // versleutelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1025, 951);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBoxLoadKeyTwoGen);
            this.Controls.Add(this.textBoxKeyTwoGen);
            this.Controls.Add(this.textBoxKeyTwoInput);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.textBoxExportOutput);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxPointers);
            this.Controls.Add(this.btnExportOutput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExportInput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxMasterKeyInput);
            this.Controls.Add(this.textBoxLoadMasterKey);
            this.Controls.Add(this.textBoxMasterKey);
            this.Controls.Add(this.textBoxLoadKeyGen);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.textBoxLoadStartText);
            this.Controls.Add(this.textBoxKeyOneGen);
            this.Controls.Add(this.textBoxLoadEnterKey);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.textBoxKeyOneInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "versleutelForm";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Versleutel berichten";
            this.Load += new System.EventHandler(this.versleutelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKeyOneInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxLoadEnterKey;
        private System.Windows.Forms.TextBox textBoxKeyOneGen;
        private System.Windows.Forms.TextBox textBoxLoadStartText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox textBoxLoadKeyGen;
        private System.Windows.Forms.TextBox textBoxMasterKey;
        private System.Windows.Forms.TextBox textBoxLoadMasterKey;
        private System.Windows.Forms.TextBox textBoxMasterKeyInput;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExportInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxPointers;
        private System.Windows.Forms.Button btnExportOutput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxExportOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.TextBox textBoxKeyTwoInput;
        private System.Windows.Forms.TextBox textBoxKeyTwoGen;
        private System.Windows.Forms.TextBox textBoxLoadKeyTwoGen;
        private System.Windows.Forms.TextBox textBox7;
    }
}

