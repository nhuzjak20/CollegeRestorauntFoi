namespace CollegeRestraunt
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
            this.button1 = new System.Windows.Forms.Button();
            this.IzlazGumb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UnosStudenta
            // 
            this.UnosStudenta.Location = new System.Drawing.Point(546, 112);
            this.UnosStudenta.Name = "UnosStudenta";
            this.UnosStudenta.Size = new System.Drawing.Size(155, 22);
            this.UnosStudenta.TabIndex = 0;
            this.UnosStudenta.Text = "Unos Studenta";
            this.UnosStudenta.UseVisualStyleBackColor = true;
            // 
            // BoxUnosStudenta
            // 
            this.BoxUnosStudenta.Location = new System.Drawing.Point(415, 112);
            this.BoxUnosStudenta.Name = "BoxUnosStudenta";
            this.BoxUnosStudenta.Size = new System.Drawing.Size(125, 22);
            this.BoxUnosStudenta.TabIndex = 1;
            this.BoxUnosStudenta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegistracijaStudenta
            // 
            this.RegistracijaStudenta.Location = new System.Drawing.Point(317, 140);
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
            this.dataGridView1.Size = new System.Drawing.Size(296, 332);
            this.dataGridView1.TabIndex = 3;
            // 
            // RegistracijaProizvoda
            // 
            this.RegistracijaProizvoda.Location = new System.Drawing.Point(546, 81);
            this.RegistracijaProizvoda.Name = "RegistracijaProizvoda";
            this.RegistracijaProizvoda.Size = new System.Drawing.Size(155, 23);
            this.RegistracijaProizvoda.TabIndex = 4;
            this.RegistracijaProizvoda.Text = "Registracija Proizvoda";
            this.RegistracijaProizvoda.UseVisualStyleBackColor = true;
            this.RegistracijaProizvoda.Click += new System.EventHandler(this.RegistracijaProizvoda_Click);
            // 
            // UnosProizvoda
            // 
            this.UnosProizvoda.Location = new System.Drawing.Point(546, 52);
            this.UnosProizvoda.Name = "UnosProizvoda";
            this.UnosProizvoda.Size = new System.Drawing.Size(155, 23);
            this.UnosProizvoda.TabIndex = 5;
            this.UnosProizvoda.Text = "Unos Proizvoda";
            this.UnosProizvoda.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 6;
            // 
            // KodProizvodaLabel
            // 
            this.KodProizvodaLabel.AutoSize = true;
            this.KodProizvodaLabel.Location = new System.Drawing.Point(314, 56);
            this.KodProizvodaLabel.Name = "KodProizvodaLabel";
            this.KodProizvodaLabel.Size = new System.Drawing.Size(95, 16);
            this.KodProizvodaLabel.TabIndex = 7;
            this.KodProizvodaLabel.Text = "Kod Proizvoda";
            // 
            // KodStudentaLabel
            // 
            this.KodStudentaLabel.AutoSize = true;
            this.KodStudentaLabel.Location = new System.Drawing.Point(314, 115);
            this.KodStudentaLabel.Name = "KodStudentaLabel";
            this.KodStudentaLabel.Size = new System.Drawing.Size(90, 16);
            this.KodStudentaLabel.TabIndex = 8;
            this.KodStudentaLabel.Text = "Kod Studenta:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CollegeRestraunt.Properties.Resources.redX;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(462, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 87);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IzlazGumb
            // 
            this.IzlazGumb.Location = new System.Drawing.Point(546, 12);
            this.IzlazGumb.Name = "IzlazGumb";
            this.IzlazGumb.Size = new System.Drawing.Size(155, 34);
            this.IzlazGumb.TabIndex = 10;
            this.IzlazGumb.Text = "Izlaz";
            this.IzlazGumb.UseVisualStyleBackColor = true;
            this.IzlazGumb.Click += new System.EventHandler(this.IzlazGumb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 399);
            this.Controls.Add(this.IzlazGumb);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button IzlazGumb;
    }
}

