using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Security.Policy;
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

            SetPropertiesSettings();

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

            GetFormPosition(pos);
        }

        #region Properties Settings Default
        private void SetPropertiesSettings()
        {
            SetDateLabelSize(Properties.Settings.Default.TextSize);
            SetDateLabelColor(Properties.Settings.Default.TextColor);
            showMonthName = Properties.Settings.Default.ShowMonthName;

            int lang = Properties.Settings.Default.Language;
            if (lang != 0) SetLangauge(lang);

            SetFormPosition((FormPosition)Properties.Settings.Default.FormPosition);
            SetOpacity(Properties.Settings.Default.Opacity);
        }

        private void GetFormPosition(FormPosition pos)
        {
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;
            int screenWidth = rect.Width;
            int screenHeight = rect.Height;

            this.Width = dateLabel.Width;
            this.Height = dateLabel.Height;

            if (pos == FormPosition.LeftTop)
            {
                this.Left = 0;
                this.Top = 0;
            }
            else if (pos == FormPosition.RightTop)
            {
                this.Left = screenWidth - this.Width;
                this.Top = 0;
            }
            else if (pos == FormPosition.LeftBottom)
            {
                this.Left = 0;
                this.Top = screenHeight - this.Height;
            }
            else
            {
                this.Left = screenWidth - this.Width;
                this.Top = screenHeight - this.Height;
            }
        }

        FormPosition pos;
        private void SetFormPosition(FormPosition pos)
        {
            this.pos = pos;

            GetFormPosition(pos);

            Properties.Settings.Default.FormPosition = (int)pos;
            Properties.Settings.Default.Save();
        }

        private void SetOpacity(double opacity)
        {
            Opacity = opacity;
            Properties.Settings.Default.Opacity = opacity;
            Properties.Settings.Default.Save();
        }

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
            Color invert = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            BackColor = invert;
            TransparencyKey = invert;

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
                contextMenuStrip1.RightToLeft = RightToLeft.Yes;
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
                formOpacityList.Text = "شفافية النص";
                formPositionsList.Text = "موضع البرنامج";
                leftTopStrip.Text = "أعلى اليسار";
                rightTopStrip.Text = "أعلى اليمين";
                leftBottomStrip.Text = "أسفل اليسار";
                rightBottomStrip.Text = "أسفل اليمين";
                progLinkStrip.Text = "رابط البرنامج";
            }
            else if (lang == 1)
            {
                contextMenuStrip1.RightToLeft = RightToLeft.No;
                shortcutStrip.Text = "Run at Windows startup";
                enableStrip.Text = "Enable";
                disableStrip.Text = "Disable";
                textSizeList.Text = "Text Size";
                textColorList.Text = "Text Color";
                textColorBlack.Text = "Black";
                textColorWhite.Text = "White";
                textColorRed.Text = "Red";
                textColorGreen.Text = "Green";
                textColorLime.Text = "Lime";
                textColorBlue.Text = "Blue";
                textColorLightBlue.Text = "Light Blue";
                textColorYellow.Text = "Yellow";
                textColorCyan.Text = "Cyan";
                textColorMagenta.Text = "Magenta";
                showMonthNameStrip.Text = "Hide Month Name";
                updateStrip.Text = "Update Date";
                closeStrip.Text = "Exit";
                languageList.Text = "Language";
                formOpacityList.Text = "Text Opacity";
                formPositionsList.Text = "Program Position";
                leftTopStrip.Text = "Left Top";
                rightTopStrip.Text = "Right Top";
                leftBottomStrip.Text = "Left Bottom";
                rightBottomStrip.Text = "Right Bottom";
                progLinkStrip.Text = "The Program Link";
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
            progLinkStrip.Click += (s, ea) => Process.Start("https://github.com/MohamedAshref371/HijriCalendar/releases/latest");

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
            textColorLightBlue.Click += (s, ea) => SetDateLabelColor(Color.FromArgb(50, 100, 255));
            textColorYellow.Click += (s, ea) => SetDateLabelColor(Color.Yellow);
            textColorCyan.Click += (s, ea) => SetDateLabelColor(Color.Cyan);
            textColorMagenta.Click += (s, ea) => SetDateLabelColor(Color.Magenta);

            leftTopStrip.Click += (s, ea) => SetFormPosition(FormPosition.LeftTop);
            rightTopStrip.Click += (s, ea) => SetFormPosition(FormPosition.RightTop);
            leftBottomStrip.Click += (s, ea) => SetFormPosition(FormPosition.LeftBottom);
            rightBottomStrip.Click += (s, ea) => SetFormPosition(FormPosition.RightBottom);

            opacity50Strip.Click += (s, ea) => SetOpacity(0.5);
            opacity60Strip.Click += (s, ea) => SetOpacity(0.6);
            opacity70Strip.Click += (s, ea) => SetOpacity(0.7);
            opacity80Strip.Click += (s, ea) => SetOpacity(0.8);
            opacity90Strip.Click += (s, ea) => SetOpacity(0.9);
            opacity100Strip.Click += (s, ea) => SetOpacity(1.0);
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
