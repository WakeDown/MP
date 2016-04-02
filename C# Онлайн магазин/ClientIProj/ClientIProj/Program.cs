using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientIProj
{
    static class Program
    {
        private static int ckeck = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EnterForm());
            if (ckeck == 1)
            {
                Application.Run(new MainForm());
            }
        }

        public static void setChek(int i)
        {
            ckeck = i;
        }
    }
}
