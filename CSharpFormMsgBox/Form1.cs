using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormMsgBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TampilkanButton_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (rbJadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (rbJadwal2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (rbJadwal3.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (rbJadwal4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }

            if (cbBiola.Checked)
            {
                kelas = kelas + "Biola, ";
            }
            if (cbDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (cbGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (cbKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            if (cbKonduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (cbPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (cbSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (kelas == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan kelas", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jadwal == "")
            {
                MessageBox.Show("Harus memilih salah satu dari pilihan jadwal", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show
                    ("Nama : " + txtNama.Text +
                    "\nJenis Kelamin : " + cbJK.Text +
                    "\nTanggal Lahir : " + dtTglLahir.Text +
                    "\nPilihan Kelas : " + kelas +
                    "\nPilihan Jadwal : " + jadwal,
                    "Informasi Pendaftaran",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SelesaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
