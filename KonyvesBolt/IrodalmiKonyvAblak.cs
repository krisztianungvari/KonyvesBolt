using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBolt
{
    public partial class IrodalmiKonyvAblak : Form
    {
        private IrodalmiKonyvOsztaly irodalmikonyvek = null;
        public IrodalmiKonyvAblak(string Cim)
        {
            InitializeComponent();
            this.Text = Cim;
            comboBox_iKKategoria.DataSource = Enum.GetValues(typeof(Kategoria));
        }
        internal IrodalmiKonyvAblak(IrodalmiKonyvOsztaly irodalmikonyvek) : this("Irodalmi könyv Módosítása")
        {
            this.irodalmikonyvek = irodalmikonyvek;

            textBox_iKCim.Text = irodalmikonyvek.Cim;
            textBox_iKSzerzo.Text = irodalmikonyvek.Szerzo;
            NUD_iK_Oldalszam.Value = irodalmikonyvek.Oldalszam;
            NUD_iKAr.Value = irodalmikonyvek.Ar;
            numericUpDown_Irodalmi.Value = irodalmikonyvek.Kiadasev;
            comboBox_iKKategoria.SelectedItem = irodalmikonyvek.Kategoria;
           
        }

        internal IrodalmiKonyvOsztaly Irodalmikonyvek { get; set; }

        private void button_iKMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_iKOk_Click(object sender, EventArgs e)
        {
            try
            {

                if (irodalmikonyvek == null)
                {
                    irodalmikonyvek = new IrodalmiKonyvOsztaly(textBox_iKCim.Text, textBox_iKSzerzo.Text, (int)NUD_iK_Oldalszam.Value, (int)NUD_iKAr.Value, (int)numericUpDown_Irodalmi.Value, (Kategoria)comboBox_iKKategoria.SelectedItem);

                    Program.adatKapcsolat.IrodalmiKonyvFelvitel(irodalmikonyvek);
                    Program.adatKapcsolat.IrodalmiKonyvekListazasa();
                    this.Close();

                }
                else // adatok módosítása
                {
                    irodalmikonyvek.Ar = (int)NUD_iKAr.Value;
                    Program.adatKapcsolat.IrodalmiKonyvModositasa(irodalmikonyvek);
                    Program.adatKapcsolat.IrodalmiKonyvekListazasa();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void IrodalmiKonyvAblak_Load(object sender, EventArgs e)
        {
            numericUpDown_Irodalmi.Maximum = DateTime.Now.Year;
            numericUpDown_Irodalmi.Value = DateTime.Now.Year;
        }
    }
}
