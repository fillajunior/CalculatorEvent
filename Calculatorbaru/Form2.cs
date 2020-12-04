using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorbaru
{
    public partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(string nama, string operasi, double a, double b, double hasils);
        public event Form2.CreateUpdateEventHandler OnCreate;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Double hasils, NilaiA, NilaiB;
            string nama = this.cmbOperasi.Text.ToLower();
            string operasi = string.Empty;
            hasils = 0;
            NilaiA = Double.Parse(this.txtNilaiA.Text);
            NilaiB = Double.Parse(this.txtNilaiB.Text);


            if (this.cmbOperasi.SelectedIndex == -1)
            {
                MessageBox.Show("Silahkan Pilih Dulu Operasinya!!!");
            }
            else if (this.cmbOperasi.SelectedIndex == 0)
            {
                hasils = NilaiA + NilaiB;

            }
            else if (this.cmbOperasi.SelectedIndex == 1)
            {
                hasils = NilaiA - NilaiB;
            }
            else if (this.cmbOperasi.SelectedIndex == 2)
            {
                hasils = NilaiA * NilaiB;
            }
            else if (this.cmbOperasi.SelectedIndex == 3)
            {
                hasils = NilaiA / NilaiB;
            }

            this.OnCreate(nama, operasi, NilaiA, NilaiB, hasils);
        }
    }
}
