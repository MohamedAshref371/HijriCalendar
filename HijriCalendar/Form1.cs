using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace HijriCalendar
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            Focus();
            BringToFront();

            DateLabel_Click(null, null);
        }

        private void DateLabel_Click(object sender, EventArgs e)
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

        private void Hijri_Click(object sender, EventArgs e) => Close();
        
    }
}
