using System;
using System.Windows.Forms;

namespace _1_4 {
    internal static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Task1_4());
        }

    }

}
