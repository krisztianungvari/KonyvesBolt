using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBolt
{
    static class Program
    {
        static public Form1 form1 = null;
        static public AdatKapcsolat adatKapcsolat = null;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            adatKapcsolat = new AdatKapcsolat();
            Application.Run(form1);
        }
    }
}
