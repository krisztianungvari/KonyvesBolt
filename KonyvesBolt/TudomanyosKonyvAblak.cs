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
  
    public partial class TudomanyosKonyvAblak : Form
    {
        private TudomanyosKonyvOsztaly tudomanyoskonyvek = null;


        public TudomanyosKonyvAblak(string Cim)
        {
            InitializeComponent();
            this.Text = Cim;
            comboBox_TKTudomany.DataSource = Enum.GetValues(typeof(TudomanyTerulet));
        }
        internal TudomanyosKonyvAblak(TudomanyosKonyvOsztaly tudomanyoskonyvek) : this("Tudományos könyv Módosítása")
        {
            this.tudomanyoskonyvek = tudomanyoskonyvek;

            textBox_TKCim.Text = tudomanyoskonyvek.Cim;
            textBox_TKSzerzo.Text = tudomanyoskonyvek.Szerzo;
            NUD_TK_Oldalszam.Value = tudomanyoskonyvek.Oldalszam;
            NUD_TKAr.Value = tudomanyoskonyvek.Ar;
            numericUpDown_Tudomany.Value = tudomanyoskonyvek.Kiadasev;
            comboBox_TKTudomany.SelectedItem = tudomanyoskonyvek.TudomanyTerulet;
            checkBox1.Checked = tudomanyoskonyvek.Elismert;
        }

        internal TudomanyosKonyvOsztaly Tudomanyoskonyvek { get; set; }

        private void button_TKMegse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_TKOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tudomanyoskonyvek == null)
                {
                    tudomanyoskonyvek = new TudomanyosKonyvOsztaly(textBox_TKCim.Text,textBox_TKSzerzo.Text,(int)NUD_TK_Oldalszam.Value,(int)NUD_TKAr.Value,(int)numericUpDown_Tudomany.Value,(TudomanyTerulet)comboBox_TKTudomany.SelectedItem,checkBox1.Checked);

                    Program.adatKapcsolat.TudomanyosKonyvFelvitel(tudomanyoskonyvek);
                    Program.adatKapcsolat.TudomanyosKonyvekListazasa();
                    this.Close();

                }
                else // adatok módosítása
                {
                    tudomanyoskonyvek.Ar = (int)NUD_TKAr.Value;
                    tudomanyoskonyvek.Elismert = checkBox1.Checked;
                    Program.adatKapcsolat.TudomanyosKonyvModositasa(tudomanyoskonyvek);
                    Program.adatKapcsolat.TudomanyosKonyvekListazasa();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void TudomanyosKonyvAblak_Load(object sender, EventArgs e)
        {
            numericUpDown_Tudomany.Maximum = DateTime.Now.Year;
        }
    }
}
