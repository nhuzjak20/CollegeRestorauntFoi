﻿namespace CollegeRestraunt
{
    partial class Form1
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
            this.UnosStudenta = new System.Windows.Forms.Button();
            this.BoxUnosStudenta = new System.Windows.Forms.TextBox();
            this.RegistracijaStudenta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistracijaProizvoda = new System.Windows.Forms.Button();
            this.UnosProizvoda = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KodProizvodaLabel = new System.Windows.Forms.Label();
            this.KodStudentaLabel = new System.Windows.Forms.Label();
            this.IzlazGumb = new System.Windows.Forms.Button();
            this.LabelCijena = new System.Windows.Forms.Label();
            this.CijenaSuma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UnosStudenta
            // 
            this.UnosStudenta.Location = new System.Drawing.Point(664, 112);
            this.UnosStudenta.Name = "UnosStudenta";
            this.UnosStudenta.Size = new System.Drawing.Size(155, 22);
            this.UnosStudenta.TabIndex = 0;
            this.UnosStudenta.Text = "Unos Studenta";
            this.UnosStudenta.UseVisualStyleBackColor = true;
            this.UnosStudenta.Click += new System.EventHandler(this.UnosStudenta_Click);
            // 
            // BoxUnosStudenta
            // 
            this.BoxUnosStudenta.Location = new System.Drawing.Point(533, 112);
            this.BoxUnosStudenta.Name = "BoxUnosStudenta";
            this.BoxUnosStudenta.Size = new System.Drawing.Size(125, 22);
            this.BoxUnosStudenta.TabIndex = 1;
            this.BoxUnosStudenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegistracijaStudenta
            // 
            this.RegistracijaStudenta.Location = new System.Drawing.Point(435, 140);
            this.RegistracijaStudenta.Name = "RegistracijaStudenta";
            this.RegistracijaStudenta.Size = new System.Drawing.Size(384, 28);
            this.RegistracijaStudenta.TabIndex = 2;
            this.RegistracijaStudenta.Text = "Registracija Studenta";
            this.RegistracijaStudenta.UseVisualStyleBackColor = true;
            this.RegistracijaStudenta.Click += new System.EventHandler(this.RegistracijaStudenta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(414, 297);
            this.dataGridView1.TabIndex = 3;
            // 
            // RegistracijaProizvoda
            // 
            this.RegistracijaProizvoda.Location = new System.Drawing.Point(664, 81);
            this.RegistracijaProizvoda.Name = "RegistracijaProizvoda";
            this.RegistracijaProizvoda.Size = new System.Drawing.Size(155, 23);
            this.RegistracijaProizvoda.TabIndex = 4;
            this.RegistracijaProizvoda.Text = "Registracija Proizvoda";
            this.RegistracijaProizvoda.UseVisualStyleBackColor = true;
            this.RegistracijaProizvoda.Click += new System.EventHandler(this.RegistracijaProizvoda_Click);
            // 
            // UnosProizvoda
            // 
            this.UnosProizvoda.Enabled = false;
            this.UnosProizvoda.Location = new System.Drawing.Point(664, 52);
            this.UnosProizvoda.Name = "UnosProizvoda";
            this.UnosProizvoda.Size = new System.Drawing.Size(155, 23);
            this.UnosProizvoda.TabIndex = 5;
            this.UnosProizvoda.Text = "Unos Proizvoda";
            this.UnosProizvoda.UseVisualStyleBackColor = true;
            this.UnosProizvoda.Click += new System.EventHandler(this.UnosProizvoda_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 6;
            // 
            // KodProizvodaLabel
            // 
            this.KodProizvodaLabel.AutoSize = true;
            this.KodProizvodaLabel.Location = new System.Drawing.Point(432, 56);
            this.KodProizvodaLabel.Name = "KodProizvodaLabel";
            this.KodProizvodaLabel.Size = new System.Drawing.Size(95, 16);
            this.KodProizvodaLabel.TabIndex = 7;
            this.KodProizvodaLabel.Text = "Kod Proizvoda";
            // 
            // KodStudentaLabel
            // 
            this.KodStudentaLabel.AutoSize = true;
            this.KodStudentaLabel.Location = new System.Drawing.Point(432, 115);
            this.KodStudentaLabel.Name = "KodStudentaLabel";
            this.KodStudentaLabel.Size = new System.Drawing.Size(90, 16);
            this.KodStudentaLabel.TabIndex = 8;
            this.KodStudentaLabel.Text = "Kod Studenta:";
            // 
            // IzlazGumb
            // 
            this.IzlazGumb.Location = new System.Drawing.Point(664, 12);
            this.IzlazGumb.Name = "IzlazGumb";
            this.IzlazGumb.Size = new System.Drawing.Size(155, 34);
            this.IzlazGumb.TabIndex = 10;
            this.IzlazGumb.Text = "Izlaz";
            this.IzlazGumb.UseVisualStyleBackColor = true;
            this.IzlazGumb.Click += new System.EventHandler(this.IzlazGumb_Click);
            // 
            // LabelCijena
            // 
            this.LabelCijena.AutoSize = true;
            this.LabelCijena.Location = new System.Drawing.Point(494, 243);
            this.LabelCijena.Name = "LabelCijena";
            this.LabelCijena.Size = new System.Drawing.Size(51, 16);
            this.LabelCijena.TabIndex = 11;
            this.LabelCijena.Text = "Cijena: ";
            // 
            // CijenaSuma
            // 
            this.CijenaSuma.AutoSize = true;
            this.CijenaSuma.Location = new System.Drawing.Point(560, 243);
            this.CijenaSuma.Name = "CijenaSuma";
            this.CijenaSuma.Size = new System.Drawing.Size(14, 16);
            this.CijenaSuma.TabIndex = 12;
            this.CijenaSuma.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv Studenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "JMBAG studenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(832, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CijenaSuma);
            this.Controls.Add(this.LabelCijena);
            this.Controls.Add(this.IzlazGumb);
            this.Controls.Add(this.KodStudentaLabel);
            this.Controls.Add(this.KodProizvodaLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UnosProizvoda);
            this.Controls.Add(this.RegistracijaProizvoda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RegistracijaStudenta);
            this.Controls.Add(this.BoxUnosStudenta);
            this.Controls.Add(this.UnosStudenta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UnosStudenta;
        private System.Windows.Forms.TextBox BoxUnosStudenta;
        private System.Windows.Forms.Button RegistracijaStudenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RegistracijaProizvoda;
        private System.Windows.Forms.Button UnosProizvoda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label KodProizvodaLabel;
        private System.Windows.Forms.Label KodStudentaLabel;
        private System.Windows.Forms.Button IzlazGumb;
        private System.Windows.Forms.Label LabelCijena;
        private System.Windows.Forms.Label CijenaSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

