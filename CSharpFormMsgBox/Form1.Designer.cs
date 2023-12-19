
namespace CSharpFormMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txtNama = new System.Windows.Forms.TextBox();
            cbJK = new System.Windows.Forms.ComboBox();
            dtTglLahir = new System.Windows.Forms.DateTimePicker();
            groupBox1 = new System.Windows.Forms.GroupBox();
            cbVokal = new System.Windows.Forms.CheckBox();
            cbSaxophone = new System.Windows.Forms.CheckBox();
            cbKomposer = new System.Windows.Forms.CheckBox();
            cbDrum = new System.Windows.Forms.CheckBox();
            cbKonduktor = new System.Windows.Forms.CheckBox();
            cbGitar = new System.Windows.Forms.CheckBox();
            cbPiano = new System.Windows.Forms.CheckBox();
            cbBiola = new System.Windows.Forms.CheckBox();
            rbJadwal3 = new System.Windows.Forms.RadioButton();
            rbJadwal2 = new System.Windows.Forms.RadioButton();
            rbJadwal1 = new System.Windows.Forms.RadioButton();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rbJadwal4 = new System.Windows.Forms.RadioButton();
            TampilkanButton = new System.Windows.Forms.Button();
            SelesaiButton = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(237, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(236, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Location = new System.Drawing.Point(237, 144);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Tanggal Lahir";
            // 
            // txtNama
            // 
            txtNama.Location = new System.Drawing.Point(376, 62);
            txtNama.Name = "txtNama";
            txtNama.Size = new System.Drawing.Size(200, 23);
            txtNama.TabIndex = 3;
            // 
            // cbJK
            // 
            cbJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbJK.FormattingEnabled = true;
            cbJK.Items.AddRange(new object[] { "Pria", "Wanita" });
            cbJK.Location = new System.Drawing.Point(376, 98);
            cbJK.Name = "cbJK";
            cbJK.Size = new System.Drawing.Size(200, 23);
            cbJK.TabIndex = 4;
            // 
            // dtTglLahir
            // 
            dtTglLahir.CustomFormat = "d MMMM yyyy";
            dtTglLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtTglLahir.Location = new System.Drawing.Point(376, 136);
            dtTglLahir.Name = "dtTglLahir";
            dtTglLahir.Size = new System.Drawing.Size(213, 23);
            dtTglLahir.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Controls.Add(cbVokal);
            groupBox1.Controls.Add(cbSaxophone);
            groupBox1.Controls.Add(cbKomposer);
            groupBox1.Controls.Add(cbDrum);
            groupBox1.Controls.Add(cbKonduktor);
            groupBox1.Controls.Add(cbGitar);
            groupBox1.Controls.Add(cbPiano);
            groupBox1.Controls.Add(cbBiola);
            groupBox1.Location = new System.Drawing.Point(91, 182);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(272, 200);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pilihan Kelas";
            // 
            // cbVokal
            // 
            cbVokal.AutoSize = true;
            cbVokal.Location = new System.Drawing.Point(140, 119);
            cbVokal.Name = "cbVokal";
            cbVokal.Size = new System.Drawing.Size(54, 19);
            cbVokal.TabIndex = 5;
            cbVokal.Text = "Vokal";
            cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            cbSaxophone.AutoSize = true;
            cbSaxophone.Location = new System.Drawing.Point(27, 119);
            cbSaxophone.Name = "cbSaxophone";
            cbSaxophone.Size = new System.Drawing.Size(85, 19);
            cbSaxophone.TabIndex = 4;
            cbSaxophone.Text = "Saxophone";
            cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbKomposer
            // 
            cbKomposer.AutoSize = true;
            cbKomposer.Location = new System.Drawing.Point(140, 160);
            cbKomposer.Name = "cbKomposer";
            cbKomposer.Size = new System.Drawing.Size(80, 19);
            cbKomposer.TabIndex = 9;
            cbKomposer.Text = "Komposer";
            cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            cbDrum.AutoSize = true;
            cbDrum.Location = new System.Drawing.Point(140, 77);
            cbDrum.Name = "cbDrum";
            cbDrum.Size = new System.Drawing.Size(56, 19);
            cbDrum.TabIndex = 3;
            cbDrum.Text = "Drum";
            cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            cbKonduktor.AutoSize = true;
            cbKonduktor.Location = new System.Drawing.Point(27, 160);
            cbKonduktor.Name = "cbKonduktor";
            cbKonduktor.Size = new System.Drawing.Size(81, 22);
            cbKonduktor.TabIndex = 8;
            cbKonduktor.Text = "Konduktor";
            cbKonduktor.UseCompatibleTextRendering = true;
            cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            cbGitar.AutoSize = true;
            cbGitar.Location = new System.Drawing.Point(27, 77);
            cbGitar.Name = "cbGitar";
            cbGitar.Size = new System.Drawing.Size(51, 19);
            cbGitar.TabIndex = 2;
            cbGitar.Text = "Gitar";
            cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            cbPiano.AutoSize = true;
            cbPiano.Location = new System.Drawing.Point(140, 36);
            cbPiano.Name = "cbPiano";
            cbPiano.Size = new System.Drawing.Size(56, 19);
            cbPiano.TabIndex = 1;
            cbPiano.Text = "Piano";
            cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            cbBiola.AutoSize = true;
            cbBiola.Location = new System.Drawing.Point(27, 36);
            cbBiola.Name = "cbBiola";
            cbBiola.Size = new System.Drawing.Size(52, 19);
            cbBiola.TabIndex = 0;
            cbBiola.Text = "Biola";
            cbBiola.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            rbJadwal3.AutoSize = true;
            rbJadwal3.Location = new System.Drawing.Point(16, 119);
            rbJadwal3.Name = "rbJadwal3";
            rbJadwal3.Size = new System.Drawing.Size(184, 19);
            rbJadwal3.TabIndex = 2;
            rbJadwal3.TabStop = true;
            rbJadwal3.Text = "Sabtu & Minggu, 09.00 - 11.00";
            rbJadwal3.UseMnemonic = false;
            rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            rbJadwal2.AutoSize = true;
            rbJadwal2.Location = new System.Drawing.Point(16, 77);
            rbJadwal2.Name = "rbJadwal2";
            rbJadwal2.Size = new System.Drawing.Size(176, 19);
            rbJadwal2.TabIndex = 1;
            rbJadwal2.TabStop = true;
            rbJadwal2.Text = "Selasa & Kamis, 14.00 - 16.00";
            rbJadwal2.UseMnemonic = false;
            rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            rbJadwal1.AutoSize = true;
            rbJadwal1.Location = new System.Drawing.Point(16, 35);
            rbJadwal1.Name = "rbJadwal1";
            rbJadwal1.Size = new System.Drawing.Size(168, 19);
            rbJadwal1.TabIndex = 0;
            rbJadwal1.TabStop = true;
            rbJadwal1.Text = "Senin & Rabu, 14.00 - 16.00";
            rbJadwal1.UseMnemonic = false;
            rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.Color.Transparent;
            groupBox2.Controls.Add(rbJadwal3);
            groupBox2.Controls.Add(rbJadwal1);
            groupBox2.Controls.Add(rbJadwal2);
            groupBox2.Controls.Add(rbJadwal4);
            groupBox2.Location = new System.Drawing.Point(397, 182);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(272, 200);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pilihan Jadwal";
            // 
            // rbJadwal4
            // 
            rbJadwal4.AutoSize = true;
            rbJadwal4.Location = new System.Drawing.Point(16, 160);
            rbJadwal4.Name = "rbJadwal4";
            rbJadwal4.Size = new System.Drawing.Size(138, 19);
            rbJadwal4.TabIndex = 0;
            rbJadwal4.TabStop = true;
            rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            rbJadwal4.UseMnemonic = false;
            rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // TampilkanButton
            // 
            TampilkanButton.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            TampilkanButton.Location = new System.Drawing.Point(288, 400);
            TampilkanButton.Name = "TampilkanButton";
            TampilkanButton.Size = new System.Drawing.Size(75, 23);
            TampilkanButton.TabIndex = 10;
            TampilkanButton.Text = "Tampilkan";
            TampilkanButton.UseVisualStyleBackColor = false;
            TampilkanButton.Click += TampilkanButton_Click;
            // 
            // SelesaiButton
            // 
            SelesaiButton.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            SelesaiButton.Location = new System.Drawing.Point(397, 400);
            SelesaiButton.Name = "SelesaiButton";
            SelesaiButton.Size = new System.Drawing.Size(75, 23);
            SelesaiButton.TabIndex = 11;
            SelesaiButton.Text = "Selesai";
            SelesaiButton.UseVisualStyleBackColor = false;
            SelesaiButton.Click += SelesaiButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            label4.Location = new System.Drawing.Point(302, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(234, 30);
            label4.TabIndex = 12;
            label4.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label4);
            Controls.Add(SelesaiButton);
            Controls.Add(TampilkanButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dtTglLahir);
            Controls.Add(cbJK);
            Controls.Add(txtNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "ASTRA MUSIC SCHOOL";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.Button TampilkanButton;
        private System.Windows.Forms.Button SelesaiButton;
        private System.Windows.Forms.Label label4;
    }
}

