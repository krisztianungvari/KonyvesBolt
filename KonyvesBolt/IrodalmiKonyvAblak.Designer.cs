
namespace KonyvesBolt
{
    partial class IrodalmiKonyvAblak
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_iKMegse = new System.Windows.Forms.Button();
            this.button_iKOk = new System.Windows.Forms.Button();
            this.comboBox_iKKategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_iKAr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUD_iK_Oldalszam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_iKSzerzo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_iKCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Irodalmi = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_iKAr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_iK_Oldalszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Irodalmi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_Irodalmi);
            this.groupBox1.Controls.Add(this.button_iKMegse);
            this.groupBox1.Controls.Add(this.button_iKOk);
            this.groupBox1.Controls.Add(this.comboBox_iKKategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NUD_iKAr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NUD_iK_Oldalszam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_iKSzerzo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_iKCim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Irodalmi könyv";
            // 
            // button_iKMegse
            // 
            this.button_iKMegse.Location = new System.Drawing.Point(0, 340);
            this.button_iKMegse.Name = "button_iKMegse";
            this.button_iKMegse.Size = new System.Drawing.Size(164, 23);
            this.button_iKMegse.TabIndex = 24;
            this.button_iKMegse.Text = "Mégse";
            this.button_iKMegse.UseVisualStyleBackColor = true;
            this.button_iKMegse.Click += new System.EventHandler(this.button_iKMegse_Click);
            // 
            // button_iKOk
            // 
            this.button_iKOk.Location = new System.Drawing.Point(0, 310);
            this.button_iKOk.Name = "button_iKOk";
            this.button_iKOk.Size = new System.Drawing.Size(164, 23);
            this.button_iKOk.TabIndex = 23;
            this.button_iKOk.Text = "OK";
            this.button_iKOk.UseVisualStyleBackColor = true;
            this.button_iKOk.Click += new System.EventHandler(this.button_iKOk_Click);
            // 
            // comboBox_iKKategoria
            // 
            this.comboBox_iKKategoria.FormattingEnabled = true;
            this.comboBox_iKKategoria.Location = new System.Drawing.Point(7, 280);
            this.comboBox_iKKategoria.Name = "comboBox_iKKategoria";
            this.comboBox_iKKategoria.Size = new System.Drawing.Size(157, 23);
            this.comboBox_iKKategoria.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Kategória";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kiadás éve";
            // 
            // NUD_iKAr
            // 
            this.NUD_iKAr.Location = new System.Drawing.Point(6, 182);
            this.NUD_iKAr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_iKAr.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NUD_iKAr.Name = "NUD_iKAr";
            this.NUD_iKAr.Size = new System.Drawing.Size(158, 23);
            this.NUD_iKAr.TabIndex = 18;
            this.NUD_iKAr.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ár";
            // 
            // NUD_iK_Oldalszam
            // 
            this.NUD_iK_Oldalszam.Location = new System.Drawing.Point(6, 133);
            this.NUD_iK_Oldalszam.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUD_iK_Oldalszam.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUD_iK_Oldalszam.Name = "NUD_iK_Oldalszam";
            this.NUD_iK_Oldalszam.Size = new System.Drawing.Size(158, 23);
            this.NUD_iK_Oldalszam.TabIndex = 16;
            this.NUD_iK_Oldalszam.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Oldal szám";
            // 
            // textBox_iKSzerzo
            // 
            this.textBox_iKSzerzo.Location = new System.Drawing.Point(6, 84);
            this.textBox_iKSzerzo.Name = "textBox_iKSzerzo";
            this.textBox_iKSzerzo.Size = new System.Drawing.Size(158, 23);
            this.textBox_iKSzerzo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Szerző";
            // 
            // textBox_iKCim
            // 
            this.textBox_iKCim.Location = new System.Drawing.Point(6, 35);
            this.textBox_iKCim.Name = "textBox_iKCim";
            this.textBox_iKCim.Size = new System.Drawing.Size(158, 23);
            this.textBox_iKCim.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cím";
            // 
            // numericUpDown_Irodalmi
            // 
            this.numericUpDown_Irodalmi.Location = new System.Drawing.Point(6, 231);
            this.numericUpDown_Irodalmi.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_Irodalmi.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown_Irodalmi.Name = "numericUpDown_Irodalmi";
            this.numericUpDown_Irodalmi.Size = new System.Drawing.Size(158, 23);
            this.numericUpDown_Irodalmi.TabIndex = 25;
            this.numericUpDown_Irodalmi.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // IrodalmiKonyvAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 391);
            this.Controls.Add(this.groupBox1);
            this.Name = "IrodalmiKonyvAblak";
            this.Text = "IrodalmiKonyvAblak";
            this.Load += new System.EventHandler(this.IrodalmiKonyvAblak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_iKAr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_iK_Oldalszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Irodalmi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_iKMegse;
        private System.Windows.Forms.Button button_iKOk;
        private System.Windows.Forms.ComboBox comboBox_iKKategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUD_iKAr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUD_iK_Oldalszam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_iKSzerzo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_iKCim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Irodalmi;
    }
}