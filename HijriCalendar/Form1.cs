using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace hijri_calendar
{
    public partial class Form1 : Form
    {
        bool showMonthName;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            AddEventHandler();

            SetDateLabelSize(Properties.Settings.Default.TextSize);
            SetDateLabelColor(Properties.Settings.Default.TextColor);
            showMonthName = Properties.Settings.Default.ShowMonthName;

            int lang = Properties.Settings.Default.Language;
            if (lang != 0) SetLangauge(lang);

            Focus();
            BringToFront();

            SetDate();
        }

        private void SetDate()
        {
            #region Configuration
            object calendarType = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Control Panel\International", "iCalendarType", null);
            bool isHijri = calendarType != null && calendarType.ToString() == "6";

            Calendar calendar;
            if (isHijri)
                calendar = new GregorianCalendar();
            else
                calendar = new HijriCalendar();

            CultureInfo cultureInfo = new CultureInfo(isHijri ? "en-US" : "ar-SA");
            cultureInfo.DateTimeFormat.Calendar = calendar;
            #endregion

            #region Show Date
            DateTime today = DateTime.Now;

            int year = calendar.GetYear(today);
            int month = calendar.GetMonth(today);
            int day = calendar.GetDayOfMonth(today);

            string monthName;
            if (showMonthName)
                monthName = " " + cultureInfo.DateTimeFormat.GetMonthName(month);
            else
                monthName = "";

            dateLabel.Text = $"{year}/{month:D2}/{day:D2}{monthName}";
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

        #region Properties Settings Default
        private void SetDateLabelSize(float size)
        {
            dateLabel.Font = new Font(dateLabel.Font.FontFamily, size);
            Properties.Settings.Default.TextSize = size;
            Properties.Settings.Default.Save();
            SetDate();
        }

        private void SetDateLabelColor(Color color)
        {
            dateLabel.ForeColor = color;
            Properties.Settings.Default.TextColor = color;
            Properties.Settings.Default.Save();
        }

        private void SetShowMonthNameBoolean()
        {
            showMonthName = !showMonthName;

            showMonthNameStrip.Text = ShowMonthNameStripText();
            Properties.Settings.Default.ShowMonthName = showMonthName;
            Properties.Settings.Default.Save();
            SetDate();
        }

        int lang = 0;
        private void SetLangauge(int lang)
        {
            this.lang = lang;
            if (lang == 0)
            {

                shortcutStrip.Text = "التشغيل عند بدء الويندوز";
                enableStrip.Text = "تفعيل";
                disableStrip.Text = "تعطيل";
                textSizeList.Text = "حجم الخط";
                textColorList.Text = "لون الخط";
                textColorBlack.Text = "أسود";
                textColorWhite.Text = "أبيض";
                textColorRed.Text = "أحمر";
                textColorGreen.Text = "أخضر";
                textColorLime.Text = "ليموني";
                textColorBlue.Text = "أزرق";
                textColorLightBlue.Text = "أزرق فاتح";
                textColorYellow.Text = "أصفر";
                textColorCyan.Text = "سماوي";
                textColorMagenta.Text = "قرمزي";
                showMonthNameStrip.Text = "إخفاء إسم الشهر";
                updateStrip.Text = "تحديث التاريخ";
                closeStrip.Text = "خروج";
                languageList.Text = "اللغة";
            }
            else if (lang == 1)
            {
                shortcutStrip.Text = "Run at Windows startup";
                enableStrip.Text = "Enable";
                disableStrip.Text = "Disable";
                textSizeList.Text = "Text size";
                textColorList.Text = "Text color";
                textColorBlack.Text = "Black";
                textColorWhite.Text = "White";
                textColorRed.Text = "Red";
                textColorGreen.Text = "Green";
                textColorLime.Text = "Lime";
                textColorBlue.Text = "Blue";
                textColorLightBlue.Text = "Light blue";
                textColorYellow.Text = "Yellow";
                textColorCyan.Text = "Cyan";
                textColorMagenta.Text = "Magenta";
                showMonthNameStrip.Text = "Hide month name";
                updateStrip.Text = "Update date";
                closeStrip.Text = "Exit";
                languageList.Text = "Language";
            }
            ShowMonthNameStripText();
            Properties.Settings.Default.Language = lang;
            Properties.Settings.Default.Save();
        }

        private string ShowMonthNameStripText()
        {
            if (lang == 1)
            {
                if (showMonthName) return "Hide month name";
                else return "Show month name";
            }
            else
            {
                if (showMonthName) return "إخفاء إسم الشهر";
                else return "إظهار إسم الشهر";
            }
        }
        #endregion

        private void AddEventHandler()
        {
            enableStrip.Click += (s, ea) => CreateStartupShortcut();
            disableStrip.Click += (s, ea) => DeleteStartupShortcut();

            showMonthNameStrip.Click += (s, ea) => SetShowMonthNameBoolean();
            updateStrip.Click += (s, ea) => SetDate();
            closeStrip.Click += (s, ea) => Close();
            dateLabel.MouseHover += (s, ea) => SetDate();

            arabicStrip.Click += (s, ea) => SetLangauge(0);
            englishStrip.Click += (s, ea) => SetLangauge(1);

            textSize8px.Click += (s, ea) => SetDateLabelSize(8);
            textSize10px.Click += (s, ea) => SetDateLabelSize(10);
            textSize12px.Click += (s, ea) => SetDateLabelSize(12);
            textSize14px.Click += (s, ea) => SetDateLabelSize(14);
            textSize16px.Click += (s, ea) => SetDateLabelSize(16);
            textSize18px.Click += (s, ea) => SetDateLabelSize(18);
            textSize20px.Click += (s, ea) => SetDateLabelSize(20);

            textColorBlack.Click += (s, ea) => SetDateLabelColor(Color.Black);
            textColorWhite.Click += (s, ea) => SetDateLabelColor(Color.White);
            textColorRed.Click += (s, ea) => SetDateLabelColor(Color.Red);
            textColorGreen.Click += (s, ea) => SetDateLabelColor(Color.Green);
            textColorLime.Click += (s, ea) => SetDateLabelColor(Color.Lime);
            textColorBlue.Click += (s, ea) => SetDateLabelColor(Color.Blue);
            textColorLightBlue.Click += (s, ea) => SetDateLabelColor(Color.LightBlue);
            textColorYellow.Click += (s, ea) => SetDateLabelColor(Color.Yellow);
            textColorCyan.Click += (s, ea) => SetDateLabelColor(Color.Cyan);
            textColorMagenta.Click += (s, ea) => SetDateLabelColor(Color.Magenta);
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
