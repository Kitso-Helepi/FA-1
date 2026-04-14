using Question2_B;
using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}