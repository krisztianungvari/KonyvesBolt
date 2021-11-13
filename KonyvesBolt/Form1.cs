using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBolt
{
    public partial class Form1 : Form
    {
        List<TudomanyosKonyvOsztaly> tudomanyoskonyv;

        public Form1()
        {
            InitializeComponent();
        }
        public void TudomanyosKonyvekFrissitese()
        {
            Program.adatKapcsolat.TudomanyosKonyvekListazasa();
        }
        public void IrodalmiKonyvekFrissitese()
        {
            Program.adatKapcsolat.IrodalmiKonyvekListazasa();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.adatKapcsolat.Csatlakozas();
            TudomanyosKonyvekFrissitese();
            IrodalmiKonyvekFrissitese();
        }

        private void button_Uj_Click(object sender, EventArgs e)
        {
            TudomanyosKonyvAblak tudomanyosKonyvAblak = new TudomanyosKonyvAblak("Új tudományos könyv");
            if (tudomanyosKonyvAblak.ShowDialog() == DialogResult.OK)
            {
                Program.adatKapcsolat.TudomanyosKonyvFelvitel(tudomanyosKonyvAblak.Tudomanyoskonyvek);
                TudomanyosKonyvekFrissitese();

            }
        }

        private void button_Modositas_Click(object sender, EventArgs e)
        {
            if (listBox_TudomanyosKonyv.SelectedIndex != -1)
            {
                TudomanyosKonyvOsztaly tudomanyoskonyvek = (TudomanyosKonyvOsztaly)listBox_TudomanyosKonyv.SelectedItem;
                TudomanyosKonyvAblak tudomanyosKonyvAblak = new TudomanyosKonyvAblak(tudomanyoskonyvek);
                if (tudomanyosKonyvAblak.ShowDialog() == DialogResult.OK)
                {
                    Program.adatKapcsolat.TudomanyosKonyvModositasa(tudomanyoskonyvek);
                    TudomanyosKonyvekFrissitese();
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy könyvet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_Torles_Click(object sender, EventArgs e)
        {
            if (listBox_TudomanyosKonyv.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan szeretné törölni ezt a könyvet?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    TudomanyosKonyvOsztaly tudomanyoskonyvek = (TudomanyosKonyvOsztaly)listBox_TudomanyosKonyv.SelectedItem;
                    Program.adatKapcsolat.TudomanyosKonyvTorlese(tudomanyoskonyvek);
                    TudomanyosKonyvekFrissitese();
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy könyvet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            try
            {
                string tudomanyos = "CSV_tudomanyoskonyvek.TXT";

                using (StreamWriter kimentes = new StreamWriter(tudomanyos, true, Encoding.Default))
                {
                    foreach (TudomanyosKonyvOsztaly item in listBox_TudomanyosKonyv.Items)
                    {
                        kimentes.Write(item.ToString());
                    }
                }

                MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Sikertelen mentés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_UjIrodalmi_Click(object sender, EventArgs e)
        {
            IrodalmiKonyvAblak irodalmiKonyvAblak = new IrodalmiKonyvAblak("Új irodalmi könyv");
            if (irodalmiKonyvAblak.ShowDialog() == DialogResult.OK)
            {
                Program.adatKapcsolat.IrodalmiKonyvFelvitel(irodalmiKonyvAblak.Irodalmikonyvek);
                IrodalmiKonyvekFrissitese();
            }
        }

        private void button_IrodalmiModositas_Click(object sender, EventArgs e)
        {
            if (listBox_IrodalmiKonyv.SelectedIndex != -1)
            {
                IrodalmiKonyvOsztaly irodalmikonyvek = (IrodalmiKonyvOsztaly)listBox_IrodalmiKonyv.SelectedItem;
                IrodalmiKonyvAblak irodalmiKonyvAblak = new IrodalmiKonyvAblak(irodalmikonyvek);
                if (irodalmiKonyvAblak.ShowDialog() == DialogResult.OK)
                {
                    Program.adatKapcsolat.IrodalmiKonyvModositasa(irodalmikonyvek);
                    IrodalmiKonyvekFrissitese();
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy könyvet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_IrodalmikonyvTorles_Click(object sender, EventArgs e)
        {
            if (listBox_IrodalmiKonyv.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan szeretné törölni ezt a könyvet?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    IrodalmiKonyvOsztaly irodalmikonyvek = (IrodalmiKonyvOsztaly)listBox_IrodalmiKonyv.SelectedItem;
                    Program.adatKapcsolat.IrodalmiKonyvTorlese(irodalmikonyvek);
                    IrodalmiKonyvekFrissitese();
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy könyvet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_IrodalmikonyvMentes_Click(object sender, EventArgs e)
        {
            try
            {
                string irodalmi = "CSV_irodalmikonyvek.TXT";

                using (StreamWriter kimentes = new StreamWriter(irodalmi, true, Encoding.Default))
                {
                    foreach (IrodalmiKonyvOsztaly item in listBox_IrodalmiKonyv.Items)
                    {
                        kimentes.Write(item.ToString());
                    }
                }

                MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Sikertelen mentés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_OsszesMentes_Click(object sender, EventArgs e)
        {
            try
            {
                string osszes = "CSV_osszeskonyv.TXT";

                using (StreamWriter kimentes = new StreamWriter(osszes, true, Encoding.Default))
                {
                    foreach (IrodalmiKonyvOsztaly item in listBox_IrodalmiKonyv.Items)
                    {
                        kimentes.Write(item.ToString());
                    } 
                    foreach (TudomanyosKonyvAblak item in listBox_TudomanyosKonyv.Items)
                    {
                        kimentes.Write(item.ToString());
                    }
                    
                }

                MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Sikertelen mentés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
