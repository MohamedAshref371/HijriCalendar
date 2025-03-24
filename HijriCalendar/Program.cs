using System;
using System.IO;
using System.Windows.Forms;

namespace hijri_calendar
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, e) =>
                LogError(e.Exception.Message, e.Exception.StackTrace);

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                Exception ex = (Exception)e.ExceptionObject;
                LogError(ex.Message, ex.StackTrace);
            };

            try
            {
                System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName + Application.CompanyName, out bool createdNew);
                if (createdNew)
                {
                    Application.Run(new Form1());
                    mutex.ReleaseMutex();
                }
                else MessageBox.Show("هناك نسخة من البرنامج مفتوحة");
            }
            catch (Exception ex)
            {
                LogError(ex.Message, ex.StackTrace);
                MessageBox.Show("حدث خطأ غير متوقع، سيتم إغلاق البرنامج");
            }
        }

        public static void LogError(string msg, string stack, bool inTryCatch = false)
        {
            if (!File.Exists("Errors.txt"))
                File.WriteAllText("Errors.txt", "");

            File.AppendAllText("Errors.txt", $"{DateTime.Now}{(inTryCatch ? "  -  Inside Custom Try-Catch Block" : "")}\n{msg}\n{stack}\n------------------\n\n");
        }
    }
}
