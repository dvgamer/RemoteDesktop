using Client.Forms;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormConnect());
                Application.Run(new FormLiveControl());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Something bad happened, and this is the final try { } catch { } block to catch it: \n\n" + ex.ToString(),
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}