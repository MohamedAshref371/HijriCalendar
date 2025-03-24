using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace HijriCalendar
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEventHandler();
            
            Focus();
            BringToFront();

            SetDate();
        }
        
        private void SetDate()
        {
            #region Configuration
            object calendarType = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "iCalendarType", null);
            bool isHijri = calendarType != null && calendarType.ToString() == "6";
            System.Globalization.HijriCalendar hijriCalendar = new System.Globalization.HijriCalendar();
            hijriCalendar.HijriAdjustment = 0;

            CultureInfo hijriCulture = new CultureInfo("ar-SA");
            hijriCulture.DateTimeFormat.Calendar = hijriCalendar;
            #endregion

            #region Show Date
            DateTime today = DateTime.Now;

            int year, month, day;
            string monthName;

            if (!isHijri)
            {
                year = hijriCalendar.GetYear(today);
                month = hijriCalendar.GetMonth(today);
                day = hijriCalendar.GetDayOfMonth(today);
                monthName = hijriCulture.DateTimeFormat.GetMonthName(month);
            }
            else
            {
                year = today.Year;
                month = today.Month;
                day = today.Day;
                monthName = today.ToString("MMM");
            }

            dateLabel.Text = $"{year}/{month:D2}/{day:D2} {monthName}";
            #endregion

            #region Form Position
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            int screenWidth = rect.Width;
            int screenHeight = rect.Height;

            this.Width = dateLabel.Width;
            this.Height = dateLabel.Height;

            this.Left = screenWidth - this.Width;
            this.Top = screenHeight - this.Height;
            #endregion
        }

        #region Date Label
        private void ChangeDateLabelSize(float size)
        {
            dateLabel.Font = new Font(dateLabel.Font.FontFamily, size);
            SetDate();
        }

        private void ChangeDateLabelColor(Color color)
        {
            dateLabel.ForeColor = color;
        }
        #endregion

        private void AddEventHandler()
        {
            enableStrip.Click += (s, ea) => CreateStartupShortcut();
            disableStrip.Click += (s, ea) => DeleteStartupShortcut();
            updateStrip.Click += (s, ea) => SetDate();
            closeStrip.Click += (s, ea) => Close();
            dateLabel.MouseHover += (s, ea) => SetDate();

            textSize8px.Click += (s, ea) => ChangeDateLabelSize(8);
            textSize10px.Click += (s, ea) => ChangeDateLabelSize(10);
            textSize12px.Click += (s, ea) => ChangeDateLabelSize(12);
            textSize14px.Click += (s, ea) => ChangeDateLabelSize(14);
            textSize16px.Click += (s, ea) => ChangeDateLabelSize(16);
            textSize18px.Click += (s, ea) => ChangeDateLabelSize(18);
            textSize20px.Click += (s, ea) => ChangeDateLabelSize(20);

            textColorBlack.Click += (s, ea) => ChangeDateLabelColor(Color.Black);
            textColorWhite.Click += (s, ea) => ChangeDateLabelColor(Color.White);
            textColorRed.Click += (s, ea) => ChangeDateLabelColor(Color.Red);
            textColorGreen.Click += (s, ea) => ChangeDateLabelColor(Color.Green);
            textColorLime.Click += (s, ea) => ChangeDateLabelColor(Color.Lime);
            textColorBlue.Click += (s, ea) => ChangeDateLabelColor(Color.Blue);
            textColorLightBlue.Click += (s, ea) => ChangeDateLabelColor(Color.LightBlue);
            textColorYellow.Click += (s, ea) => ChangeDateLabelColor(Color.Yellow);
            textColorCyan.Click += (s, ea) => ChangeDateLabelColor(Color.Cyan);
            textColorMagenta.Click += (s, ea) => ChangeDateLabelColor(Color.Magenta);
        }

        #region Startup Shortcut
        private void CreateStartupShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupPath, $"{Application.ProductName} - Shortcut.lnk");

            if (File.Exists(shortcutPath))
                File.Delete(shortcutPath);

            IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
            IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);

            shortcut.TargetPath = Application.ExecutablePath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.WindowStyle = 1;
            shortcut.Description = $"Shortcut to {Application.ProductName} Application";
            shortcut.IconLocation = Application.ExecutablePath;

            shortcut.Save();
        }

        public void DeleteStartupShortcut()
        {
            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string shortcutPath = Path.Combine(startupPath, $"{Application.ProductName} - Shortcut.lnk");

            if (File.Exists(shortcutPath))
                File.Delete(shortcutPath);
        }
        #endregion

    }
}
